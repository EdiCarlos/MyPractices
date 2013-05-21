// Copyright Microsoft

using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace Microsoft.Samples.SqlServer.WordAddin
{
    public static class OpcHelper
    {
    /// <summary>
    /// Returns the part contents in xml
    /// </summary>
    /// <param name="part">System.IO.Packaging.Packagepart</param>
    /// <returns></returns>
    static XElement GetContentsAsXml(PackagePart part)
    {
        XNamespace pkg = 
           "http://schemas.microsoft.com/office/2006/xmlPackage";
        if (part.ContentType.EndsWith("xml"))
        {
            using (Stream partstream = part.GetStream())
            using (StreamReader streamReader = new StreamReader(partstream))
            {
                string streamString = streamReader.ReadToEnd();
                XElement newXElement = 
                    new XElement(pkg + "part", new XAttribute(pkg + "name", part.Uri), 
                        new XAttribute(pkg + "contentType", part.ContentType), 
                        new XElement(pkg + "xmlData", XElement.Parse(streamString)));
                return newXElement;
            }
         }
        else
        {
            using (Stream str = part.GetStream())
            using (BinaryReader binaryReader = new BinaryReader(str))
            {
                int len = (int)binaryReader.BaseStream.Length;
                byte[] byteArray = binaryReader.ReadBytes(len);
                // the following expression creates the base64String, then chunks
                // it to lines of 76 characters long
                string base64String = (System.Convert.ToBase64String(byteArray))
                    .Select
                    (
                        (c, i) => new
                        {
                            Character = c,
                            Chunk = i / 76
                        }
                    )
                    .GroupBy(c => c.Chunk)
                    .Aggregate(
                        new StringBuilder(),
                        (s, i) =>
                            s.Append(
                                i.Aggregate(
                                    new StringBuilder(),
                                    (seed, it) => seed.Append(it.Character),
                                    sb => sb.ToString()
                                )
                            )
                            .Append(Environment.NewLine),
                        s => s.ToString()
                    );

                return new XElement(pkg + "part",
                    new XAttribute(pkg + "name", part.Uri),
                    new XAttribute(pkg + "contentType", part.ContentType),
                    new XAttribute(pkg + "compression", "store"),
                    new XElement(pkg + "binaryData", base64String)
                );
            }
        }
    }
    /// <summary>
    /// Returns an XDocument
    /// </summary>
    /// <param name="package">System.IO.Packaging.Package</param>
    /// <returns></returns>
    public static XDocument OpcToFlatOpc(Package package)
    {
        XNamespace 
            pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";
        XDeclaration 
            declaration = new XDeclaration("1.0", "UTF-8", "yes");
        XDocument doc = new XDocument(
            declaration,
            new XProcessingInstruction("mso-application", "progid=\"Word.Document\""),
            new XElement(pkg + "package",
                new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                package.GetParts().Select(part => GetContentsAsXml(part))
            )
        );
        return doc;
    }
    /// <summary>
    /// Returns a System.IO.Packaging.Package stream for the given range.
    /// </summary>
    /// <param name="range">Range in word document</param>
    /// <returns></returns>
    public static Stream GetPackageStreamFromRange(this Range range)
    {
        XDocument doc = XDocument.Parse(range.WordOpenXML);
        XNamespace pkg =
           "http://schemas.microsoft.com/office/2006/xmlPackage";
        XNamespace rel =
            "http://schemas.openxmlformats.org/package/2006/relationships";
        Package InmemoryPackage = null;
        
        //NEXT: Learn how to wrap memStream in a using statement.
        //      using(MemoryStream memStream = new MemoryStream()){} results in 
        //      "Cannot open package because FileMode or FileAccess value is not valid for the stream." exception
        MemoryStream memStream = new MemoryStream();
        using (InmemoryPackage = Package.Open(memStream, FileMode.Create))
        {
            // add all parts (but not relationships)
            foreach (var xmlPart in doc.Root
                .Elements()
                .Where(p =>
                    (string)p.Attribute(pkg + "contentType") !=
                    "application/vnd.openxmlformats-package.relationships+xml"))
            {
                string name = (string)xmlPart.Attribute(pkg + "name");
                string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                if (contentType.EndsWith("xml"))
                {
                    Uri u = new Uri(name, UriKind.Relative);
                    PackagePart part = InmemoryPackage.CreatePart(u, contentType,
                        CompressionOption.SuperFast);
                    using (Stream str = part.GetStream(FileMode.Create))
                    using (XmlWriter xmlWriter = XmlWriter.Create(str))
                        xmlPart.Element(pkg + "xmlData")
                            .Elements()
                            .First()
                            .WriteTo(xmlWriter);
                }
                else
                {
                    Uri u = new Uri(name, UriKind.Relative);
                    PackagePart part = InmemoryPackage.CreatePart(u, contentType,
                        CompressionOption.SuperFast);
                    using (Stream str = part.GetStream(FileMode.Create))
                    using (BinaryWriter binaryWriter = new BinaryWriter(str))
                    {
                        string base64StringInChunks =
                        (string)xmlPart.Element(pkg + "binaryData");
                        char[] base64CharArray = base64StringInChunks
                            .Where(c => c != '\r' && c != '\n').ToArray();
                        byte[] byteArray =
                            System.Convert.FromBase64CharArray(base64CharArray,
                            0, base64CharArray.Length);
                        binaryWriter.Write(byteArray);
                    }
                }
            }
            foreach (var xmlPart in doc.Root.Elements())
            {
                string name = (string)xmlPart.Attribute(pkg + "name");
                string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                if (contentType ==
                    "application/vnd.openxmlformats-package.relationships+xml")
                {
                    // add the package level relationships
                    if (name == "/_rels/.rels")
                    {
                        foreach (XElement xmlRel in
                            xmlPart.Descendants(rel + "Relationship"))
                        {
                            string id = (string)xmlRel.Attribute("Id");
                            string type = (string)xmlRel.Attribute("Type");
                            string target = (string)xmlRel.Attribute("Target");
                            string targetMode =
                                (string)xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                                InmemoryPackage.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            else
                                InmemoryPackage.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
                        }
                    }
                    else
                    // add part level relationships
                    {
                        string directory = name.Substring(0, name.IndexOf("/_rels"));
                        string relsFilename = name.Substring(name.LastIndexOf('/'));
                        string filename =
                            relsFilename.Substring(0, relsFilename.IndexOf(".rels"));
                        PackagePart fromPart = InmemoryPackage.GetPart(
                            new Uri(directory + filename, UriKind.Relative));
                        foreach (XElement xmlRel in
                            xmlPart.Descendants(rel + "Relationship"))
                        {
                            string id = (string)xmlRel.Attribute("Id");
                            string type = (string)xmlRel.Attribute("Type");
                            string target = (string)xmlRel.Attribute("Target");
                            string targetMode =
                                (string)xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            else
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
                        }
                    }
                }
            }
            InmemoryPackage.Flush();
        }
            
        return memStream;        
    }
}
}

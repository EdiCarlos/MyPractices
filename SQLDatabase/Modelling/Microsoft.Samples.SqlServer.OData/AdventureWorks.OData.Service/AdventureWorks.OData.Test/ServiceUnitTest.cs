
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Data.SqlTypes;

using System.Drawing;
using System.Drawing.Imaging;

//Arrange, Act, Assert
//Given, When, Then
namespace AdventureWorks2012_ODataTest
{
    public class Column
    {
        public string SchemaName { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int? DataSize { get; set; }
    }


    [TestClass]
    public class ServiceUnitTest
    {
        private XNamespace edmXmlns = "http://schemas.microsoft.com/ado/2009/11/edm";
        string InArgument_Url = "http://localhost/AdventureWorks_ODataService/AdventureWorks.svc/$metadata";
   
        [TestMethod]
        public void GetResourceNamesTestMethod()
        {
            //Given: A url to a WCF 5.0 service is given as InArgument_Url
            
            //When: A LINQ to XML query is constructed with an EntitySet element
            IEnumerable<string> resources = from x in XElement.Load(InArgument_Url)
                .Descendants(edmXmlns.GetName("EntitySet"))
                select x.Attribute("Name").Value;

            //Then: Retrun an IEnumerable list of Entity Data Model resource names
            Assert.IsTrue(resources.Count<string>() > 0);
        }

        public void GetProductImages()
        {
            //Arrange:           
            string columnName = "LargePhoto";
            string filePath = string.Format(@"C:\Projects\Microsoft.Samples.SqlServer.OData\AdventureWorks.OData.Service\AdventureWorks.OData.Service\ProductImages\{0}\", columnName);

            //Act:
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Setup the command
                    command.CommandText = string.Format("SELECT ProductPhotoID, {0} FROM Production.ProductPhoto", columnName);
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            SqlBytes bytes = reader.GetSqlBytes(1);
                            using (Bitmap productImage = new Bitmap(bytes.Stream))
                            {
                                String fileName = string.Format("{0}{1}.gif", filePath, reader[0].ToString());

                                // Save in gif format.
                                productImage.Save(fileName, ImageFormat.Gif);
                            }
                        }

                    }
                }
            }
        }

        [TestMethod]
        public void GetProductPhotoID()
        {
            //Arrange:
            int productID = 332;
            int productPhotoID = 0;
                       
            //Act:
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Setup the command
                    command.CommandText = "SELECT ProductPhotoID FROM Production.ProductProductPhoto WHERE ProductID=@ProductID";
                    command.CommandType = CommandType.Text;

                    // Declare the parameter
                    SqlParameter paramID =
                        new SqlParameter("@ProductID", SqlDbType.Int);
                    paramID.Value = productID;
                    command.Parameters.Add(paramID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        reader.Read();
                        if (reader.HasRows)
                            productPhotoID = (int)reader[0];
                    }
                }
            }

            //Assert:
            Assert.IsTrue(productPhotoID > 0);
        }

        [TestMethod]
        public void GetProductImageStream()
        {
            //Arrange:
            int productID = 332;
            Stream productStream = null;

            //Act:
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Setup the command
                    command.CommandText = "SELECT LargePhoto FROM Production.vProductCatalogImages WHERE ProductID=@ProductID";
                    command.CommandType = CommandType.Text;

                    // Declare the parameter
                    SqlParameter paramID =
                        new SqlParameter("@ProductID", SqlDbType.Int);
                    paramID.Value = productID;
                    command.Parameters.Add(paramID);

                    connection.Open();


                    //command.ExecuteReader();
                    //Stream GetStream
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        reader.Read();
                        if (reader.HasRows)
                            productStream = reader.GetStream(0);
                    }
                }
            }

            //Assert:
            Assert.IsTrue(productStream.Length > 0);
        }


        private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,  
            // you can retrieve it from a configuration file, using the  
            // System.Configuration.ConfigurationSettings.AppSettings property  
            return "Data Source=(local);Initial Catalog=AdventureWorks2012;Integrated Security=SSPI;";
        }
    }
}

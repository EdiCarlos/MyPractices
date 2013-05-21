using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace Sample1
{
    class Program
    {
        static Hashtable table = new Hashtable();
        static void Main(string[] args)
        {
            #region NA
            //Dictionary<string, string> header = new Dictionary<string, string>();

            //XDocument xDocument = XDocument.Load(@"d:\documents and settings\axkhan2\desktop\sample.xml");
            //var fileData = from xdoc in xDocument.Descendants("InvoiceHeader") select xdoc;
            //InvoiceHeaderDetails headerDetails;

            //foreach (XElement element in fileData)
            //{
            //    headerDetails = new InvoiceHeaderDetails(element);
            //    header = headerDetails.GetHeaderDetails();
            //}
            //var shipments = from elements in xDocument.Descendants("InvoiceData").Descendants("Shipment_Collection").Descendants("Shipment") select elements;

            //ShipmentDetails shipmentDet;
            //foreach (XElement items in shipments)
            //{
            //    shipmentDet = new ShipmentDetails(items);
            //    Dictionary<string, string> dic = shipmentDet.Shipment;
            //}
            //xDocument.Save(@"d:\documents and settings\axkhan2\desktop\schema.xml");
            #endregion

            string inputXML = @"<Request><BuyerUSBCCustomerID Value='5600'/><BuyerOrgID Value='12274'/><SellerUSBCCustomerID Value='5601'/><SellerOrgID Value='12286'/><DocHeaderDRN Value=''/><BuyerMarket Value=''/><BuyerSector Value=''/><Direction Value=''/><BuyerIndustry Value='HC'/><DocumentType Value='Order'/><OwnerDocumentPK Value=''/><IsGenerated Value='N'/><SourceSystem Value='5627'/><DocSource Value='HC'/><DXTransactionSetSID Value=''/><AnchorID Value=''/><PrimaryMatchID Value=''/><DocNumber Value=''/><BuyerDocNumber Value='ord#1235'/><OwnerFlag Value='B'/><FinancialStatus Value=''/><IsDocumentOwner Value=''/><IsBuyerOwner Value='Y'/><ActionCode Value='2'/><SearchLoadAuth Value='N'/><ReturnDBDebug Value='Y'/><DupString Value=''/><GenDupString Value=''/><BuyerIDCode Value='ROrg1'/><BuyerIDCodeQualifier Value='1'/><SellerIDCode Value='REGSELL1'/><SellerIDCodeQualifier Value='2'/><InvoiceNumber Value=''/><TransportMode Value=''/><OriginState Value=''/><DestState Value=''/></Request>";
            IEnumerable<XElement> requestElements = XElement.Parse(inputXML).Descendants().Select((e) => { Console.WriteLine(e.Name.LocalName + " " + e.FirstAttribute.Value); return e; });

            Parallel.ForEach(XElement.Parse(inputXML).Descendants(), (e) => { if (!table.ContainsKey(e.Name.LocalName)) { table.Add(e.Name.LocalName, e.FirstAttribute.Value); } });
            
            //foreach (DictionaryEntry col in table.GetEnumerator())
            //{
            //    Console.WriteLine(col.Key+" =========== " + col.Value);
            //}
            IEnumerator iterate = table.GetEnumerator();
            while (iterate.MoveNext())
            {
                DictionaryEntry entry = (DictionaryEntry)iterate.Current;
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            //foreach (XElement element in requestElements)
            //{
            //    Console.WriteLine(element.Name.LocalName +" " + element.Attribute("Value").Value);
            //    table.Add(element.Name.LocalName, element.FirstAttribute.Value);
            //}
          

        }

        public static void DecodeXml(XElement element)
        {
            table.Add(element.Name, element.Value);
        }
    }


    class ShipmentDetails
    {
        Dictionary<string, string> shipment;
        public ShipmentDetails(XElement element)
        {
            shipment = new Dictionary<string, string>();
            GetShipmentDetails(element);
            GetCostDetails(element.Descendants("CostDetails").Descendants("CostElement"));
        }

        private void GetCostDetails(IEnumerable<XElement> iEnumerable)
        {
            foreach (XElement element in iEnumerable)
            {
                switch(element.GetElementValue("CostDescription").ToUpper().Trim())
                {
                    case "AIR FREIGHT":
                        shipment.Add("trans", element.GetElementValue("Amount"));
                        break;
                    case "CLERICAL HANDLING CHARGES":
                        shipment.Add("handling", element.GetElementValue("Amount"));
                        break;
                    case "FUEL SURCHARGE":
                        shipment.Add("fuel_schg", element.GetElementValue("Amount"));
                        break;
                    case "TAXI":
                        shipment.Add("doc_fee", element.GetElementValue("Amount"));
                        break;
                }
            }
        }

        private void GetShipmentDetails(XElement shipmentElement)
        {
            shipment.Add("pro_number", shipmentElement.GetElementValue("FileNumber"));
            shipment.Add("mode", shipmentElement.GetElementValue("TransportType"));
            shipment.Add("wieght", shipmentElement.GetElementValue("Weight"));
            shipment.Add("dim_wt", shipmentElement.GetElementValue("ChargeableWeight"));
            shipment.Add("org_apt", shipmentElement.GetElementValue("PortOfDeparture"));
            shipment.Add("org_city", shipmentElement.GetElementValue("LoadingPlace"));
            shipment.Add("dest_apt", shipmentElement.GetElementValue("PortOfArrival"));
            shipment.Add("dest_city", shipmentElement.GetElementValue("FinalDestination"));
            shipment.Add("dest_cty", shipmentElement.GetElementValue("IsoCountryCode"));
            shipment.Add("rccode", shipmentElement.GetElementValue("DocumentReference"));
        }

        public Dictionary<string, string> Shipment
        {
            get { return shipment; }
        }

    }
    class InvoiceHeaderDetails
    {
        XElement headerElement;
        Dictionary<string, string> headerDetails;
        public InvoiceHeaderDetails()
        {
            headerDetails = new Dictionary<string, string>();
        }
        public InvoiceHeaderDetails(XElement element)
        {
            headerElement = element;
            headerDetails = new Dictionary<string, string>();
            GetHeaderDetailsInvoiceFrom(element.Descendants("PartnerDetails").Descendants("InvoiceFrom").First());
            GetHeaderDetailsFromInvoiceTo(element.Descendants("PartnerDetails").Descendants("InvoiceTo").First());
            GetHeaderDetailsFromInvoiceSummary(element.Descendants("InvoiceSummary").First());

        }

        private void GetHeaderDetailsInvoiceFrom(XElement invoiceFromElement)
        {
            headerDetails.Add("carrname", invoiceFromElement.GetElementValue("Name"));
            headerDetails.Add("scac", invoiceFromElement.GetElementValue("VATNumber"));
        }

        private void GetHeaderDetailsFromInvoiceTo(XElement element)
        {
            headerDetails.Add("scac_client", element.GetElementValue("VATNumber"));
        }
        private void GetHeaderDetailsFromInvoiceSummary(XElement element)
        {
            headerDetails.Add("mastinvno", element.GetElementValue("InvoiceNumber"));
            headerDetails.Add("inv_date", element.GetElementValue("InvoiceDate"));
            headerDetails.Add("paid_flag", element.GetElementValue("Currency"));
        }

        public Dictionary<string, string> GetHeaderDetails()
        {
            return headerDetails;
        }


    }
    static class GetElement
    {
        public static string GetElementValue(this XElement element, string Name)
        {
            string val = string.Empty;
            foreach (var item in element.Elements())
            {
                    if (item.Name == Name && item.HasElements == false)
                        val = item.Value;
            }
            return val;
            //return (from item in element.Elements() where item.Name == Name && item.HasElements == false select item.Value).First();
        }
    }
}


namespace EAISchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://EAISchemas.Request",@"Request")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::EAISchemas.PropertySchema.GrandTotal), XPath = @"/*[local-name()='Request' and namespace-uri()='http://EAISchemas.Request']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='GrandTotal' and namespace-uri()='']", XsdType = @"decimal")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EAISchemas.PropertySchema.PropertySchema", typeof(global::EAISchemas.PropertySchema.PropertySchema))]
    public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://EAISchemas.Request"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://EAISchemas.PropertySchema"" targetNamespace=""http://EAISchemas.Request"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://EAISchemas.PropertySchema"" location=""EAISchemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Request"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:GrandTotal"" xpath=""/*[local-name()='Request' and namespace-uri()='http://EAISchemas.Request']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='GrandTotal' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""RequestID"" type=""xs:string"" />
              <xs:element name=""OrderDate"" type=""xs:date"" />
              <xs:element name=""GrandTotal"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Description"" type=""xs:string"" />
                    <xs:element name=""UnitPrice"" type=""xs:unsignedInt"" />
                    <xs:element name=""Quantity"" type=""xs:unsignedInt"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Request() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Request";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}

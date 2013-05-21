namespace EAISchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://EAISchemas.RequestDecline",@"Response")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Response"})]
    public sealed class RequestDecline : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://EAISchemas.RequestDecline"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://EAISchemas.RequestDecline"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ReqID"" type=""xs:string"" />
        <xs:element name=""GrandTotal"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RequestDecline() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Response";
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

namespace EAISchemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EAISchemas.Request", typeof(global::EAISchemas.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EAISchemas.RequestDecline", typeof(global::EAISchemas.RequestDecline))]
    public sealed class MapToReqDecline : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://EAISchemas.Request"" xmlns:ns0=""http://EAISchemas.RequestDecline"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Request"" />
  </xsl:template>
  <xsl:template match=""/s0:Request"">
    <ns0:Response>
      <ReqID>
        <xsl:value-of select=""Header/RequestID/text()"" />
      </ReqID>
      <GrandTotal>
        <xsl:value-of select=""Header/GrandTotal/text()"" />
      </GrandTotal>
    </ns0:Response>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EAISchemas.Request";
        
        private const string _strTrgSchemasList0 = @"EAISchemas.RequestDecline";
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"EAISchemas.Request";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"EAISchemas.RequestDecline";
                return _TrgSchemas;
            }
        }
    }
}

namespace Kartverket.Geosynkronisering
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeStoredQueries", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class DescribeStoredQueriesType : BaseRequestType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryId", DataType="anyURI")]
        public StringCollection StoredQueryId;
    }
}

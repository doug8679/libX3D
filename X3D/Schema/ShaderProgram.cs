[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public partial class ShaderProgram : object, System.Xml.Serialization.IXmlSerializable
{
    
    private System.Xml.XmlNode[] nodesField;
    
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ShaderProgram", "");
    
    public System.Xml.XmlNode[] Nodes
    {
        get
        {
            return this.nodesField;
        }
        set
        {
            this.nodesField = value;
        }
    }
    
    public void ReadXml(System.Xml.XmlReader reader)
    {
        this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
    }
    
    public void WriteXml(System.Xml.XmlWriter writer)
    {
        System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
    }
    
    public System.Xml.Schema.XmlSchema GetSchema()
    {
        return null;
    }
    
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }
}
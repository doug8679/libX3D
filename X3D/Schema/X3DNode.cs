using System.Xml;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough]
[System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[XmlSchemaProvider("ExportSchema")]
[XmlRoot(IsNullable=false)]
public abstract class X3DNode : IXmlSerializable {
    private static XmlQualifiedName typeName = new XmlQualifiedName("X3DNode", "");

    protected X3DMetadataObject metadata;

    public void ReadXml(XmlReader reader) {
        ReadAttributesXml(reader);
        ReadElementsXml(reader);
    }

    public void WriteXml(XmlWriter writer) {
        WriteAttributesXml(writer);
        WriteElementsXml(writer);
    }

    public System.Xml.Schema.XmlSchema GetSchema() { return null; }

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    protected virtual void ReadAttributesXml(XmlReader reader) {}

    protected virtual void ReadElementsXml(XmlReader reader) {
        // TODO: Read metadata if present...
    }
    protected virtual void WriteAttributesXml(XmlWriter writer) {}

    protected virtual void WriteElementsXml(XmlWriter writer) {
        metadata.WriteXml(writer);
    }
}
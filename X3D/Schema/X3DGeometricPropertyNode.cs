using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public abstract class X3DGeometricPropertyNode :  X3DNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("X3DGeometricPropertyNode", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    protected X3DMetadataObject metadata;

    #region Overrides of X3DNode

    protected override void ReadElementsXml(XmlReader reader) {
        base.ReadElementsXml(reader);
        // Read metadata if present;
    }

    protected override void WriteElementsXml(XmlWriter writer) {
        base.WriteElementsXml(writer);
        metadata.WriteXml(writer);
    }
    #endregion
}
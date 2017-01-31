using System.Collections.Generic;
using System.Xml;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class StaticGroup :  X3DBoundedObject {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("StaticGroup", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    public X3DChildNode[] Children { get; set; }

    #region Overrides of X3DNode

    protected override void ReadElementsXml(XmlReader reader) { base.ReadElementsXml(reader); }

    protected override void WriteElementsXml(XmlWriter writer) {
        base.WriteElementsXml(writer);
        foreach ( var child in Children ) {
            child.WriteXml(writer);
        }
    }

    #endregion
}
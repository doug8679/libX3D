using System.Xml;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProvider("ExportSchema")]
[System.Xml.Serialization.XmlRoot(IsNullable=false)]
public abstract class X3DGeometryNode : X3DNode {
    private static XmlQualifiedName typeName = new XmlQualifiedName("X3DGeometryNode", "");

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }
}
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[XmlSchemaProvider("ExportSchema")]
[XmlRoot(IsNullable = false)]
public class Box : X3DGeometryNode {
    public float[] Size { get; set; }
    public bool Solid { get; set; }

    private static XmlQualifiedName typeName = new XmlQualifiedName("Box", "");

    protected override void ReadAttributesXml(XmlReader reader) {
        Solid = bool.Parse(reader["solid"] ?? "true");
        Size = reader["size"]?.Split(' ').Select(v => float.Parse(v, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray();
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        writer.WriteAttributeString("size", string.Join(" ", Size));
        writer.WriteAttributeString("solid", Solid.ToString().ToLower());
    }
    
    public static XmlQualifiedName ExportSchema(XmlSchemaSet schemas) {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }
}
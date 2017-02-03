using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
public class Cone : X3DGeometryNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Cone", "");

    public X3DMetadataObject Metadata { get; set; }
    public bool Bottom { get; set; }
    public float BottomRadius { get; set; }
    public float Height { get; set; }
    public bool Side { get; set; }
    public bool Solid { get; set; }

    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        Bottom = bool.Parse(reader["bottom"] ?? "true");
        BottomRadius = float.Parse(reader["bottomRadius"] ?? "1.0", NumberStyles.Any, CultureInfo.InvariantCulture);
        Height = float.Parse(reader["height"] ?? "2.0", NumberStyles.Any, CultureInfo.InvariantCulture);
        Side = bool.Parse(reader["side"] ?? "true");
        Solid = bool.Parse(reader["solid"] ?? "true");
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("bottom", Bottom.ToString().ToLower());
        writer.WriteAttributeString("bottomRadius", BottomRadius.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("height", Height.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("side", Side.ToString().ToLower());
        writer.WriteAttributeString("solid", Solid.ToString().ToLower());
    }
    #endregion
}
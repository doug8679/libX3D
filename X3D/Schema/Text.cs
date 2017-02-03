using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Text :  X3DGeometryNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Text", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private X3DFontStyleNode fontStyle;
    private float[] length = new float[0];
    private float maxExtent = 0f;
    private string[] strings = new string[0];
    private float[] lineBounds = new float[2];
    private float[] origin = new float[3];
    private float[] textBounds = new float[2];
    private bool solid = false;

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        strings = reader["string"]?.Split(' ') ?? new string[0];
        length = reader["length"]?.Split(' ').Select(l => float.Parse(l, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new float[0];
        maxExtent = float.Parse(reader["maxExtent"] ?? "0.0", NumberStyles.Any, CultureInfo.InvariantCulture);
        solid = bool.Parse(reader["solid"] ?? "false");
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("string", string.Join(" ", strings));
        writer.WriteAttributeString("length", string.Join(" ", length));
        writer.WriteAttributeString("maxExtent", maxExtent.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("solid", solid.ToString().ToLower());
    }
    #endregion
}
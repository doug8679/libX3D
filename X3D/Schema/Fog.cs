using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Fog : X3DBindableNode, X3DFogObject {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Fog", "");
    private float[] _color;
    private string _fogType;
    private float _visibilityRange;

    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    #region Implementation of X3DFogObject
    public float[] Color { get { return _color; } set { _color = value; } }
    public string FogType { get { return _fogType; } set { _fogType = value; } }
    public float VisibilityRange { get { return _visibilityRange; } set { _visibilityRange = value; } }
    #endregion

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        _color = reader["color"]?.Split(' ').Select(c => float.Parse(c, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] {1f, 1f, 1f};
        _fogType = reader["fogType"] ?? "LINEAR";
        _visibilityRange = float.Parse(reader["visibilityRange"] ?? "0", NumberStyles.Any, CultureInfo.InvariantCulture);
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("color", string.Join(" ", _color));
        writer.WriteAttributeString("fogType", _fogType);
        writer.WriteAttributeString("visibilityRange", _visibilityRange.ToString(CultureInfo.InvariantCulture));
    }

    #endregion
}
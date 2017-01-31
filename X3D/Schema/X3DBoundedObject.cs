using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
public abstract class X3DBoundedObject : X3DChildNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("X3DBoundedObject", "");

    private float[] bboxCenter = {0f, 0f, 0f};
    private float[] bboxSize = {-1f, -1f, -1f};

    protected override void ReadAttributesXml(XmlReader reader) {
        bboxCenter =
            reader["bboxCenter"]?.Split(' ')
                                .Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture))
                                .ToArray() ?? new[] {0f, 0f, 0f};
        bboxSize =
            reader["bboxSize"]?.Split(' ')
                              .Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture))
                              .ToArray() ?? new[] {-1f, -1f, -1f};
    }
    protected override void WriteAttributesXml(XmlWriter writer) {
        writer.WriteAttributeString("bboxCenter", string.Join(" ", bboxCenter));
        writer.WriteAttributeString("bboxSize", string.Join(" ", bboxSize));
    }
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }
}
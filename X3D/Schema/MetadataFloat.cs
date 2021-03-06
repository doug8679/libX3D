using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class MetadataFloat : X3DMetadataObject {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("MetadataFloat", "");
    private float[] _value;

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    public float[] Value { get { return _value; } set { _value = value; } }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader)
    {
        base.ReadAttributesXml(reader);
        _value =
            reader["value"]?.Split(' ')
                           .Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture))
                           .ToArray() ?? new float[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer)
    {
        base.WriteAttributesXml(writer);
        if (_value?.Length > 0)
            writer.WriteAttributeString("value", string.Join(" ", _value));
    }
    #endregion
}
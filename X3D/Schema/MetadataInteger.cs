using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class MetadataInteger : X3DMetadataObject {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("MetadataInteger", "");
    private int[] _value;

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    public int[] Value { get { return _value; } set { _value = value; } }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader)
    {
        base.ReadAttributesXml(reader);
        _value =
            reader["value"]?.Split(' ')
                           .Select(e => int.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture))
                           .ToArray() ?? new int[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer)
    {
        base.WriteAttributesXml(writer);
        if (_value?.Length > 0)
            writer.WriteAttributeString("value", string.Join(" ", _value));
    }
    #endregion
}
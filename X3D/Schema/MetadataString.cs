using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class MetadataString :  X3DMetadataObject {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("MetadataString", "");
    private string[] _value;

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    public string[] Value { get { return _value; } set { _value = value; } }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader)
    {
        base.ReadAttributesXml(reader);
        _value = reader["value"]?.Split(' ').ToArray() ?? new string[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer)
    {
        base.WriteAttributesXml(writer);
        if (_value?.Length > 0)
            writer.WriteAttributeString("value", string.Join(" ", _value));
    }
    #endregion
}
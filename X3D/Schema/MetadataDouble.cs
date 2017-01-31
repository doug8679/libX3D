using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProvider("ExportSchema")]
[System.Xml.Serialization.XmlRoot(IsNullable=false)]
public class MetadataDouble : X3DMetadataObject {
    private static XmlQualifiedName typeName = new XmlQualifiedName("MetadataDouble", "");
    private double[] _value;

    public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    public double[] Value { get { return _value; } set { _value = value; } }
    
    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        _value =
            reader["value"]?.Split(' ')
                           .Select(e => double.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture))
                           .ToArray() ?? new double[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        if (_value?.Length > 0)
            writer.WriteAttributeString("value", string.Join(" ", _value));
    }
    #endregion
}
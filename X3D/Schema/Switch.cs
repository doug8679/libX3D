using System.Globalization;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
public class Switch : X3DGroupingNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Switch", "");

    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private int _whichChoice = -1;
    public int WhichChoice { get { return _whichChoice; } set { _whichChoice = value; } }

    #region Overrides of X3DBoundedObject

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        _whichChoice = int.Parse(reader["whichCoice"] ?? "-1", NumberStyles.Any, CultureInfo.InvariantCulture);
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("whichChoice", _whichChoice.ToString(CultureInfo.InvariantCulture));
    }

    #endregion
}
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class WorldInfo :  X3DInfoNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("WorldInfo", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private string[] _info = new string[0];
    private string _title = "";
    public string[] Info { get { return _info; } set { _info = value; } }
    public string Title { get { return _title; } set { _title = value; } }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        _title = reader["title"] ?? "";
        _info = reader["info"]?.Split(' ') ?? new string[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("title", _title);
        writer.WriteAttributeString("info", string.Join(" ", _info));
    }

    #endregion
}
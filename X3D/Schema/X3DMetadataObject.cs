using System.Xml;
using System.Xml.Serialization;

public abstract class X3DMetadataObject : X3DNode {
    
    public string Name { get; set; }
    public string Reference { get; set; }

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        Name = reader["name"] ?? "";
        Reference = reader["reference"] ?? "";
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("name", Name);
        writer.WriteAttributeString("reference", Reference);
    }

    #endregion
}
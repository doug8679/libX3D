using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough]
[System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[XmlSchemaProvider("ExportSchema")]
[XmlRoot("Scene", IsNullable=false)]
public class Scene :  SceneGraphStructureNodeType {
    private static XmlQualifiedName typeName = new XmlQualifiedName("Scene", "");
    public static XmlQualifiedName ExportSchema(XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    // ChildContentModelCore Elements
    [XmlElement("MetadataBoolean", typeof(MetadataBoolean))]
    [XmlElement("MetadataDouble", typeof(MetadataDouble))]
    [XmlElement("MetadataFloat", typeof(MetadataFloat))]
    [XmlElement("MetadataInteger", typeof(MetadataInteger))]
    [XmlElement("MetadataSet", typeof(MetadataSet))]
    [XmlElement("MetadataString", typeof(MetadataString))]
    // ChildContentModelInterchange Elements
    [XmlElement("MetadataString", typeof(Background))]
    [XmlElement("MetadataString", typeof(ColorInterpolator))]
    [XmlElement("MetadataString", typeof(CoordinateInterpolator))]
    [XmlElement("MetadataString", typeof(DirectionalLight))]
    [XmlElement("MetadataString", typeof(Group))]
    [XmlElement("MetadataString", typeof(NavigationInfo))]
    [XmlElement("MetadataString", typeof(NormalInterpolator))]
    [XmlElement("MetadataString", typeof(OrientationInterpolator))]
    [XmlElement("MetadataString", typeof(PositionInterpolator))]
    [XmlElement("MetadataString", typeof(ScalarInterpolator))]
    [XmlElement("MetadataString", typeof(Shape))]
    [XmlElement("MetadataString", typeof(TimeSensor))]
    [XmlElement("MetadataString", typeof(Transform))]
    [XmlElement("MetadataString", typeof(Viewpoint))]
    [XmlElement("MetadataString", typeof(WorldInfo))]
    X3DNode[] children = new X3DNode[0];

    #region Implementation of IXmlSerializable
    public XmlSchema GetSchema() { throw new System.NotImplementedException(); }
    public void ReadXml(XmlReader reader) { throw new System.NotImplementedException(); }
    public void WriteXml(XmlWriter writer) { throw new System.NotImplementedException(); }
    #endregion
}
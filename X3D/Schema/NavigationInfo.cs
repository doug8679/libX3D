using System.Globalization;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class NavigationInfo :  X3DBindableNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("NavigationInfo", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private bool set_bind;
    private float[] avatarSize = {0.25f, 1.6f, 0.75f};
    private bool headlight = true;
    private float speed = 1f;
    private float transitionTime = 1f;
    private string[] transitionType = {"LINEAR"};
    private string[] type = {"EXAMINE", "ANY"};
    private float visibilityLimit = 0f;
    private float bindTime;
    private bool isBound;
    private bool transitionComplete;

    #region Overrides of X3DNode
    protected override void ReadAttributesXml(XmlReader reader) { base.ReadAttributesXml(reader); }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("avatarSize", string.Join(" ", avatarSize));
        writer.WriteAttributeString("headlight", headlight.ToString().ToLower());
        writer.WriteAttributeString("speed",speed.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("type", string.Join(" ", type));
        writer.WriteAttributeString("transitionType", string.Join(" ", transitionType));
        writer.WriteAttributeString("transitionTime", transitionTime.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("visibilityLimit", visibilityLimit.ToString(CultureInfo.InvariantCulture));
    }
    #endregion
}
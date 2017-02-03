using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class LOD : X3DGroupingNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("LOD", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private int level_changed;
    private bool forceTransitions = false;
    float[] range = new float[0];
    private float[] center = {0f, 0f, 0f};

    #region Overrides of X3DBoundedObject
    protected override void ReadAttributesXml(XmlReader reader) { base.ReadAttributesXml(reader); }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("forceTransitions", forceTransitions.ToString().ToLower());
        writer.WriteAttributeString("center", string.Join(" ", center));
        writer.WriteAttributeString("range", string.Join(" ", range));
    }
    #endregion
}
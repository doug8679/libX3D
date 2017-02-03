using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public abstract class X3DViewpointNode : X3DBindableNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("X3DViewpointNode", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    /*private double[] centerOfRotation = {0, 0, 0};*/
    private string description = "";
    private bool jump = true;
    private double[] orientation = {0, 0, 1, 0};
    /*private double[] position = {0, 0, 10};*/
    private bool retainUserOffsets = false;

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) { base.ReadAttributesXml(reader); }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("description", description);
        writer.WriteAttributeString("jump", jump.ToString().ToLower());
        writer.WriteAttributeString("orientation", string.Join(" ", orientation));
        writer.WriteAttributeString("retainUserOffsets", retainUserOffsets.ToString().ToLower());
    }

    #endregion
}
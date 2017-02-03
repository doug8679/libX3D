using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class TextureBackground :  X3DBackgroundNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("TextureBackground", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private X3DTextureNode backTexture, bottomTexture, frontTexture, leftTexture, rightTexture, topTexture;

    #region Overrides of X3DNode

    protected override void ReadElementsXml(XmlReader reader) { base.ReadElementsXml(reader); }

    protected override void WriteElementsXml(XmlWriter writer) {
        base.WriteElementsXml(writer); 
        backTexture?.WriteXml(writer);
        bottomTexture?.WriteXml(writer);
        frontTexture?.WriteXml(writer);
        leftTexture?.WriteXml(writer);
        rightTexture?.WriteXml(writer);
        topTexture?.WriteXml(writer);
    }
    #endregion
}
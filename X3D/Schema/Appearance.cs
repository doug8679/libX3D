[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Appearance :  X3DAppearanceNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Appearance", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private FillProperties fillProperties;
    private LineProperties lineProperties;
    private X3DMaterialNode material;
    private X3DShaderNode[] shaders;
    private X3DTextureNode texture;
    private X3DTextureTransformNode textureTransform;
}
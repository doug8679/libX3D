[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class TextureTransform :  X3DTextureTransformNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("TextureTransform", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private float[] center = {0f, 0f};
    private float rotation = 0f;
    private float[] scale = {1f, 1f};
    private float[] translation = {0f, 0f};
}
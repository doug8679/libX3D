[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class TextureProperties : X3DNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("TextureProperties", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private float anisotropicDegree = 1f;
    private ColorRGBA borderColor = new ColorRGBA(0, 0, 0, 0);
    private int borderWidth = 0;
    private string boundaryModeS = "REPEAT";
    private string boundaryModeT = "REPEAT";
    private string boundaryModeR = "REPEAT";
    private string magnificationFilter = "FASTEST";
    private string minificationFilter = "FASTEST";
    private string textureCompression = "FASTEST";
    private float texturePriority = 0f;
    private bool generateMipMaps = false;
}
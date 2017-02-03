using System.Collections.Generic;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public abstract class X3DComposedGeometryNode : X3DGeometryNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("X3DComposedGeometryNode", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private List<X3DVertexAttributeNode> attrib;
    private X3DColorNode color;
    private X3DCoordinateNode coord;
    private FogCoordinate fogCoord;
    private X3DMetadataObject metadata;
    private X3DNormalNode normal;
    private X3DTextureCoordinateNode textCoord;
    private bool ccw;
    private bool colorPerVertex;
    private bool normalPerVertex;
    private bool solid;
}
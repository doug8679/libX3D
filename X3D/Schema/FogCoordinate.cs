using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class FogCoordinate :  X3DGeometricPropertyNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("FogCoordinate", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    float[] depth = new float[0];

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        depth = reader["depth"]?.Split(' ').Select(d => float.Parse(d, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new float[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("depth", string.Join(" ", depth));
    }

    #endregion
}
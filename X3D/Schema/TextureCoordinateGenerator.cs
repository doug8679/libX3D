using System;
using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class TextureCoordinateGenerator :  X3DTextureCoordinateNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("TextureCoordinateGenerator", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }
    private TextureMode mode = TextureMode.SPHERE;
    float[] parameter = new float[0];

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader)
    {
        base.ReadAttributesXml(reader);
        mode = (TextureMode)Enum.Parse(typeof(TextureMode), (reader["mode"] ?? "SPHERE").Replace("-", "_"));
        parameter = reader["parameter"]?.Split(' ').Select(p => float.Parse(p, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new float[0];
    }

    protected override void WriteAttributesXml(XmlWriter writer)
    {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("mode", mode.ToString().Replace("_", "-"));
        writer.WriteAttributeString("parameter", string.Join(" ", parameter));
    }
    #endregion
}

public enum TextureMode
{
    SPHERE,
    CAMERASPACENORMAL,
    CAMERASPACEPOSITION,
    CAMERASPACEREFLECTIONVECTOR,
    SPHERE_LOCAL,
    COORD,
    COORD_EYE,
    NOISE,
    NOISE_EYE,
    SPHERE_REFLECT,
    SPHERE_REFLECT_LOCAL
}
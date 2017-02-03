using System;
using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Transform :  X3DGroupingNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Transform", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private float[] center = {0f, 0f, 0f};
    private float[] rotation = {0f, 0f, 1f, 0f};
    private float[] scale = {1f, 1f, 1f};
    private float[] scaleOrientation = {0f, 0f, 1f, 0f};
    private float[] translation = {0f, 0f, 0f};

    #region Overrides of X3DBoundedObject

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        center = reader["center"]?.Split(' ').Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] {0f, 0f, 0f};
        rotation = reader["rotation"]?.Split(' ').Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] {0f, 0f, 1f, 0f};
        scale = reader["scale"]?.Split(' ').Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] {1f, 1f, 1f};
        scaleOrientation = reader["scaleOrientation"]?.Split(' ').Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] { 0f, 0f, 1f, 0f };
        translation = reader["translation"]?.Split(' ').Select(e => float.Parse(e, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new[] { 0f, 0f, 0f };
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("center", string.Join(" ", center));
        writer.WriteAttributeString("rotation", string.Join(" ", rotation));
        writer.WriteAttributeString("scale", string.Join(" ", scale));
        writer.WriteAttributeString("scaleOrientation", string.Join(" ", scaleOrientation));
        writer.WriteAttributeString("translation", string.Join(" ", translation));
    }

    #endregion
}
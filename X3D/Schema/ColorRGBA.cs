using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class ColorRGBA :  X3DColorNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ColorRGBA", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    List<float[]> color = new List<float[]>();
    private int v1;
    private int v2;
    private int v3;
    private int v4;

    public ColorRGBA(float r, float g, float b, float a) {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    #region Overrides of X3DNode
    protected override void ReadAttributesXml(XmlReader reader)
    {
        base.ReadAttributesXml(reader);
        var cols = reader["color"] ?? "";
        var parts = cols.Split(' ').Select(p => float.Parse(p, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray();
        for (int i = 0; i < parts.Length; i += 4)
        {
            color.Add(parts.Skip(i).Take(4).ToArray());
        }
    }

    protected override void WriteAttributesXml(XmlWriter writer)
    {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("color", string.Join(" ", color.Select(c => string.Join(" ", c))));
    }
    #endregion
}
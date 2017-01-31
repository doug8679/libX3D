using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Color : X3DColorNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Color", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    List<float[]> color = new List<float[]>();

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        var cols = reader["color"] ?? "";
        var parts = cols.Split(' ').Select(p=>float.Parse(p, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray();
        for ( int i = 0; i < parts.Length; i += 3 ) {
            color.Add(parts.Skip(i).Take(3).ToArray());
        }
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("color", string.Join(" ", color.Select(c=> string.Join(" ", c))));
    }

    #endregion
}
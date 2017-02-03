using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class Coordinate :  X3DCoordinateNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Coordinate", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    List<float[]> point = new List<float[]>();

    #region Overrides of X3DNode

    protected override void ReadAttributesXml(XmlReader reader) {
        base.ReadAttributesXml(reader);
        var pts = reader["point"]?.Split(' ').Select(p => float.Parse(p, NumberStyles.Any, CultureInfo.InvariantCulture)).ToArray() ?? new float[0];
        for ( int i = 0; i < pts.Length; i+=3 ) {
            point.Add(pts.Skip(i).Take(3).ToArray());
        }
    }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer);
        writer.WriteAttributeString("point", string.Join(" ", point.Select(p=>string.Join(" ", p))));
    }
    #endregion
}
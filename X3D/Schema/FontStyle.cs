using System;
using System.Globalization;
using System.Xml;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public class FontStyle :  X3DFontStyleNode {
    private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("FontStyle", "");
    public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
    {
        System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
        return typeName;
    }

    private string[] family = {"SERIF"};
    private bool horizontal = true;
    private FontJustify justify = FontJustify.BEGIN;
    private string language = "";
    private bool leftToRight = true;
    private float size = 1f;
    private float spacing = 1f;
    private Style style = Style.PLAIN;
    private bool topToBottom = true;

    #region Overrides of X3DNode
    protected override void ReadAttributesXml(XmlReader reader) { base.ReadAttributesXml(reader); }

    protected override void WriteAttributesXml(XmlWriter writer) {
        base.WriteAttributesXml(writer); 
        writer.WriteAttributeString("family", string.Join(" ", family));
        writer.WriteAttributeString("horizontal", horizontal.ToString().ToLower());
        writer.WriteAttributeString("justify", justify.ToString());
        writer.WriteAttributeString("language", language);
        writer.WriteAttributeString("leftToRight", leftToRight.ToString().ToLower());
        writer.WriteAttributeString("size", size.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("spacing", spacing.ToString(CultureInfo.InvariantCulture));
        writer.WriteAttributeString("style", style.ToString());
        writer.WriteAttributeString("topToBottom", topToBottom.ToString().ToLower());
    }
    #endregion
}

[Flags]
public enum FontJustify {
    BEGIN = 0x01,
    END = 0x02,
    FIRST = 0x04,
    MIDDLE = 0x08
}

[Flags]
public enum Style {
    PLAIN = 0x01,
    BOLD = 0x02,
    ITALIC = 0x04,
    BOLDITALIC = 0x08
}
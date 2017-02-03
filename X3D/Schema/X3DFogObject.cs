using System.Xml.Serialization;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public interface X3DFogObject : IXmlSerializable {
    float[] Color { get; set; }
    string FogType { get; set; }
    float VisibilityRange { get; set; }
}
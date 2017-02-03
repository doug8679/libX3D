using System.Xml.Serialization;

namespace libX3D.Schema {
    [System.Diagnostics.DebuggerStepThrough]
    [System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [XmlSchemaProvider("ExportSchema")]
    [XmlRoot("head", IsNullable=false)]
    public class head :  SceneGraphStructureNodeType {
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("head", "");

        public void ReadXml(System.Xml.XmlReader reader) {
            // TODO: Read head object content
        }

        public void WriteXml(System.Xml.XmlWriter writer) {
            component?.WriteXml(writer);
            unit?.WriteXml(writer);
            meta?.WriteXml(writer);
        }
    
        public System.Xml.Schema.XmlSchema GetSchema() { return null; }
    
        public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }

        [XmlElement("meta")]
        private meta meta;
        [XmlElement("component")]
        private component component;
        [XmlElement("unit")]
        private unit unit;
    }
}
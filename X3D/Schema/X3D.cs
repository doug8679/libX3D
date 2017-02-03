using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace libX3D.Schema {
    [System.Diagnostics.DebuggerStepThrough]
    [System.CodeDom.Compiler.GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [XmlSchemaProvider("ExportSchema")]
    [XmlRoot("X3D", IsNullable = false)]
    public class X3D : SceneGraphStructureNodeType {
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("X3D", "");

        public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }

        [XmlElement("head")]
        private head head;
        [XmlElement("Scene")]
        private Scene scene;

        public XmlSchema GetSchema() { return null; }

        public void ReadXml(XmlReader reader) {
            reader.MoveToContent();
            var isEmptyElement = reader.IsEmptyElement;
            reader.ReadStartElement();
            if ( !isEmptyElement ) { scene = new XmlSerializer(typeof(Scene)).Deserialize(reader) as Scene; }
        }

        public void WriteXml(XmlWriter writer) { }
    }
}
using libX3D.Fields;

namespace libX3D.Schema {
    [System.Diagnostics.DebuggerStepThrough]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
    public class meta :  SceneGraphStructureNodeType {
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("meta", "");
    
        public void ReadXml(System.Xml.XmlReader reader) {}
    
        public void WriteXml(System.Xml.XmlWriter writer) {}
    
        public System.Xml.Schema.XmlSchema GetSchema() { return null; }
    
        public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas) {
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }

        private SFString name;
        private SFString content;
        private metaDirectionValues dir;
        private SFString httpEquiv;
        private SFString lang;
        private SFString scheme;
    }
}
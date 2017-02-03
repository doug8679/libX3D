﻿namespace X3D.Fields {
    public class SFNode : Field {

        public SFNode() {
        }

        public SFNode(BaseNode value) {
            Node = value;
        }

        public BaseNode Node { get; set; }

        public override void AcceptVisitor(IFieldVisitor visitor) {
            visitor.visit(this);
        }

        public override Field Clone() {
            return new SFNode(Node != null ? Node.clone() : null);
        }

        public override FieldType Type {
            get { return FieldType.SFNode; }
        }

        public override string ToString() {
            return string.Format("[{0}]", Node);
        }
    }
}

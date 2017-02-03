namespace X3D.Fields {
    public class MFNode : MField<BaseNode> {

        public override void AcceptVisitor(IFieldVisitor visitor) {
            visitor.visit(this);
        }

        public override Field Clone() {
            var clone = new MFNode();
            foreach (var child in Values) {
                clone.AppendValue(child.clone());
            }
            return clone;
        }

        public override FieldType Type {
            get { return FieldType.MFNode; }
        }

    }
}

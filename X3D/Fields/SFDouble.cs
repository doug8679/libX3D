namespace libX3D.Fields {
    public class SFDouble : Field {

        public SFDouble() { }

        public SFDouble(double value) { Value = value; }

        public double Value { get; set; }

        public static implicit operator SFDouble(double value) { return new SFDouble(value); }

        public override void AcceptVisitor(IFieldVisitor visitor) { visitor.visit(this); }

        public override Field Clone() { return new SFDouble(Value); }

        public override FieldType Type { get { return FieldType.SFDouble; } }

        public override string ToString() { return Value.ToString(); }


    }
}
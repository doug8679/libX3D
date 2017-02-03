﻿using System;

namespace libX3D.Fields {
    public abstract class Field : ICloneable {

        protected Field()
            : this(FieldAccessType.ExposedField) {
        }

        protected Field(FieldAccessType accessType) {
            this.accessType = accessType;
        }

        public abstract FieldType Type { get; }

        private readonly FieldAccessType accessType;
        public FieldAccessType getAccessType() {
            return accessType;
        }

        public abstract void AcceptVisitor(IFieldVisitor visitor);

        public abstract Field Clone();

        #region ICloneable Members

        object ICloneable.Clone() {
            return this.Clone();
        }

        #endregion

        public static Field CreateField(string fieldType) {
            switch (fieldType) {
                case "SFColor":
                    return new SFColor();
                case "SFFloat":
                    return new SFFloat();
                case "SFInt32":
                    return new SFInt32();
                default:
                    throw new InvalidVRMLSyntaxException("Unknown fieldType: '" + fieldType + "'");
            }
        }
    }
}

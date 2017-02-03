﻿using System;
using System.Collections.Generic;

namespace X3D.Fields {

    public abstract class MField : Field {

        protected MField()
            : base() {
        }
    }

    public abstract class MField<T> : MField, IEnumerable<T> {

        protected MField() {
        }

        protected MField(params T[] items) {
            _values = new List<T>(items);
        }

        private List<T> _values = new List<T>();
        public virtual IEnumerable<T> Values => _values;

        public virtual T this[int index] {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public virtual int length => _values.Count;

        public virtual void AppendValue(T value) {
            _values.Add(value);
        }

        public virtual void clearValues() {
            _values.Clear();
        }

        public override string ToString() {
            /*string childStr = "";
            foreach (var item in Values) {
                if (!string.IsNullOrEmpty(childStr)) childStr += ", \r\n";
                childStr += item.ToString();
            }*/
            return $"[{string.Join(", \n\r", Values)}]";
            //return $"[{childStr}]";
        }

        protected static void ParseMField(ParserContext context, Action<ParserContext> itemParser) {
            var next = context.PeekNextToken();
            if (next.Type == VRML97TokenType.OpenBracket) {
                context.ReadOpenBracket();
                while (true) {
                    next = context.PeekNextToken();
                    if (next.Type == VRML97TokenType.CloseBracket) break;
                    itemParser(context);
                }
                context.ReadCloseBracket();
            } else {
                itemParser(context);
            }
        }


        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator() {
            return (IEnumerator<T>)Values.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return _values.GetEnumerator();
        }

        #endregion
    }
}

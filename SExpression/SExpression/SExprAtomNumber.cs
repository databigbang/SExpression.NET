using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SExpression
{
    public class SExprAtomNumber: ISExpression
    {
        private readonly string _value;

        public SExprAtomNumber(string value)
        {
            this._value = value;
        }


        public override string ToString()
        {
            return this._value;
        }

        public Types Type { get { return Types.Atom | Types.Number; } }
    }
}

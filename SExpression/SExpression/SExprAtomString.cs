using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SExpression
{
    public class SExprAtomString: ISExpression
    {
        private readonly string _value;

        public SExprAtomString(string value)
        {
            this._value = value;
        }


        public override string ToString()
        {
            return this._value;
        }

        public Types Type { get { return Types.Atom | Types.String; } }

    }
}

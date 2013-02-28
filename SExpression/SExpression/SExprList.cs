using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SExpression
{
    public class SExprList: ArrayList, ISExpression
    {
        public SExprList(IEnumerable<ISExpression> list)
        {
            foreach (var sexpr in list)
            {
                this.Add(sexpr);
            }
        }

        public Types Type { get { return Types.List; } }
    }
}

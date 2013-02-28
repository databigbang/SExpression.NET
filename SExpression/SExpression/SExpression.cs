using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SExpression.GeneratedCode;
using OMetaSharp;

namespace SExpression
{
    public class SExpression
    {
        public static ISExpression Parse(string sexpr)
        {
            return Grammars.ParseWith<SExpressionParser>(sexpr, x => x.SExpression).As<ISExpression>();
        }

        public static void PrettyPrint(string sexpr)
        {
            ISExpression x = SExpression.Parse(sexpr);

            RecursivePrettyPrint(x, 0);
        }

        private static void RecursivePrettyPrint(ISExpression x, int depth)
        {
            Console.Write(new String('\t', depth));

            if ((x.Type & Types.Atom) == Types.Atom)
            {
                if((x.Type & Types.String) == Types.String)
                {
                    Console.WriteLine(String.Format("string: \"{0}\"", x.ToString()));
                } else if((x.Type & Types.Symbol) == Types.Symbol)
                {
                    Console.WriteLine(String.Format("symbol: {0}", x.ToString()));
                } else if((x.Type & Types.Number) == Types.Number) {
                    Console.WriteLine(String.Format("number: {0}", x.ToString()));
                }
            }
            else if((x.Type & Types.List) == Types.List)
            {
                Console.WriteLine("list");
                SExprList list = x as SExprList;
                foreach (ISExpression y in list)
                {
                    SExpression.RecursivePrettyPrint(y, depth + 1);
                }
            }
        }
    }
}

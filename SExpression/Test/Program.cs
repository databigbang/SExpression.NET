using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SExpression;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SExpression.SExpression.PrettyPrint("(38 \"b ddf\\\"e eee\" (c d) (e f (g h)))");
            Console.WriteLine("---------------------------------");
            SExpression.SExpression.PrettyPrint("nil");
            Console.WriteLine("---------------------------------");
            SExpression.SExpression.PrettyPrint("()");
            Console.WriteLine("---------------------------------");
            SExpression.SExpression.PrettyPrint("(+ 1 2 3 (* 4 5 6) (- 7 8 9) (/ 1 2))");
        }
    }
}

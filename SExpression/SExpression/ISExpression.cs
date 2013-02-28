using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SExpression
{
    [Flags]
    public enum Types
    {
        None = 0x0,
        List = 0x1,
        Atom = 0x2,
        Symbol = 0x4,
        String = 0x8,
        Number = 0x10,
    }

    public interface ISExpression
    {
        string ToString();

        Types Type { get; }
    }
}

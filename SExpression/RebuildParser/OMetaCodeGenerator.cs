using System.IO;
using OMetaSharp;

namespace SExpression.Utils.RebuildParser
{
    public class OMetaCodeGenerator
    {
        public static void RebuildParser()
        {
            var contents = File.ReadAllText(@"..\..\..\SExpression\SExpression.ometacs");
            var result = Grammars.ParseGrammarThenOptimizeThenTranslate
                <OMetaParser, OMetaOptimizer, OMetaTranslator>
                (contents,
                 p => p.Grammar,
                 o => o.OptimizeGrammar,
                 t => t.Trans);

            File.WriteAllText(@"..\..\..\SExpression\GeneratedCode\SExpressionParser.cs", result);
        }
    }
}
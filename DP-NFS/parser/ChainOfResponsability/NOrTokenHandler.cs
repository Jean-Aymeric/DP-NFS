using DP_NFS.Interpreter;
using System;
using System.Collections.Generic;


namespace DP_NFS.parser.ChainOfResponsability {
    class NOrTokenHandler : TokenHandler {
        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            if (treeText.Token.Equals("nor", StringComparison.InvariantCultureIgnoreCase)) {
                if (treeText.CountChildren == 2) {
                    return new NOrExpression(   TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(0))), 
                                                TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(1))));
                }
            }
            return this.Next.Execute(expression, treeText);
        }
    }
}

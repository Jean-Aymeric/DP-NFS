using DP_NFS.Interpreter;
using System;
using System.Collections.Generic;


namespace DP_NFS.parser.ChainOfResponsability {
    class AndTokenHandler : TokenHandler {
        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            if (treeText.Token.Equals("and", StringComparison.InvariantCultureIgnoreCase)) {
                if (treeText.CountChildren == 2) {
                    return new AndExpression(   TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(0))), 
                                                TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(1))));
                }
            }
            return this.Next.Execute(expression, treeText);
        }
    }
}

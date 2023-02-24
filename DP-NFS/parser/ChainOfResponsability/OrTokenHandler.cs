using DP_NFS.Interpreter;
using System;
using System.Collections.Generic;


namespace DP_NFS.parser.ChainOfResponsability {
    class OrTokenHandler : TokenHandler {
        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            if (treeText.Token.Equals("or", StringComparison.InvariantCultureIgnoreCase)) {
                if (treeText.CountChildren == 2) {
                    return new OrExpression(   TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(0))), 
                                                TokenHandlerChain.Instance.Execute(expression, new ParserTreeText(treeText.GetChild(1))));
                }
            }
            return this.Next.Execute(expression, treeText);
        }
    }
}

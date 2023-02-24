using DP_NFS.Interpreter;
using System;
using System.Collections.Generic;


namespace DP_NFS.parser.ChainOfResponsability {
    class BooleanMatrix2x2TokenHandler : TokenHandler {
        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            if (treeText.Token.Equals("", StringComparison.InvariantCultureIgnoreCase)) {
                if (treeText.CountChildren == 4) {
                    return new BooleanMatrix2x2Expression(  treeText.GetChild(0).Element.Equals("0") ? false : true,
                                                            treeText.GetChild(1).Element.Equals("0") ? false : true,
                                                            treeText.GetChild(2).Element.Equals("0") ? false : true,
                                                            treeText.GetChild(3).Element.Equals("0") ? false : true);
                }
            }
            return this.Next.Execute(expression, treeText);
        }
    }
}

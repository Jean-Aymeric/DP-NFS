using DP_NFS.Interpreter;
using System;


namespace DP_NFS.parser.ChainOfResponsability {
    abstract class TokenHandler {
        public TokenHandler Next { get; set; }

        public abstract IExpression Execute(IExpression expression, ParserTreeText treeText);
    }
}

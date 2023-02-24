using DP_NFS.Interpreter;



namespace DP_NFS.parser.ChainOfResponsability {
    class ErrorTokenHandler : TokenHandler {
        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            return new ErrorExpression();
        }
    }
}

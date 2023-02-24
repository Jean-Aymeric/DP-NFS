using DP_NFS.Interpreter;
using System;

namespace DP_NFS.parser.ChainOfResponsability {
    class TokenHandlerChain : TokenHandler {
        private static TokenHandlerChain _instance = null;
        public static TokenHandlerChain Instance {
            get {
                if (TokenHandlerChain._instance == null) {
                    TokenHandlerChain._instance = new TokenHandlerChain();
                }
                return TokenHandlerChain._instance;
            }
        }

        private TokenHandlerChain() : base() {
            TokenHandler last = this;
            last = TokenHandlerChain.AddNext(last, new AndTokenHandler());
            last = TokenHandlerChain.AddNext(last, new OrTokenHandler());
            last = TokenHandlerChain.AddNext(last, new BooleanMatrix2x2TokenHandler());
            last = TokenHandlerChain.AddNext(last, new ErrorTokenHandler());
        }

        private static TokenHandler AddNext(TokenHandler current, TokenHandler next) {
            current.Next = next;
            return next;
        }

        public override IExpression Execute(IExpression expression, ParserTreeText treeText) {
            return Next.Execute(expression, treeText);
        }
    }
}

using DP_NFS.Interpreter;
using DP_NFS.parser.ChainOfResponsability;
using System;
using System.Collections.Generic;


namespace DP_NFS.parser {
    abstract class Parser {
        public const char OpenCharacter = '(';
        public const char CloseCharacter = ')';
        public const char SeparatorCharacter = ',';

        public static IExpression Parse(String textToParse) {
            return Parser.Parse(new ParserTreeText(textToParse));
        }

        private static IExpression Parse(ParserTreeText treeText) {
            IExpression expression = null;
            return TokenHandlerChain.Instance.Execute(expression, treeText);
        }
    }
}

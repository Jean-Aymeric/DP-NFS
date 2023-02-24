using DP_NFS.Interpreter;
using DP_NFS.parser;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            String operation = "or(and((0,0,0,0), (1,1,1,1)), nor((1,0,1,0), (0,0,1,1)))";
            IExpression expression = Parser.Parse(operation);
             
            Context context = new Context();
            expression.Interpreter(context);
            Console.WriteLine(operation + " = " + context);
        }
    }
}

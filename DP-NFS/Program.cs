using DP_NFS.Interpreter;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Context context = new Context();
            IExpression expression = new AndExpression(
                                        new NotExpression(
                                            new BooleanMatrix2x2Expression(new BooleanExpression("True"), new BooleanExpression("False"),
                                                                           new BooleanExpression("False"), new BooleanExpression("True"))
                                        ),
                                        new BooleanMatrix2x2Expression(new BooleanExpression("True"), new BooleanExpression("True"),
                                                                        new BooleanExpression("False"), new BooleanExpression("False"))
                                     );
            expression.Interpreter(context);
            Console.WriteLine(context.Matrix2x2);
        }
    }
}

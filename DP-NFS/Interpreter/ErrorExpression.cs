using System;


namespace DP_NFS.Interpreter {
    class ErrorExpression : TerminalExpression {
        public BooleanMatrix2x2 Booleans { get; set; }

        public override void Interpreter(Context context) {
            context.Matrix2x2 = null;
            context.IsWrong = true;
        }
    }
}
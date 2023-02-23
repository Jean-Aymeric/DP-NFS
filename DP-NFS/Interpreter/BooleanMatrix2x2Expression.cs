using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class BooleanMatrix2x2Expression : TerminalExpression {
        public BooleanExpression[,] Booleans { get; set; }

        public BooleanMatrix2x2Expression(BooleanExpression a0, BooleanExpression a1, BooleanExpression b0, BooleanExpression b1) : base("BooleanMatrix2x2") {
            this.Booleans = new BooleanExpression[2, 2] { { a0, a1 }, { b0, b1 } };
        }

        public override void Interpreter(Context context) {
            context.Matrix2x2 = new BooleanMatrix2x2(this.Booleans[0, 0].Boolean, this.Booleans[0, 1].Boolean, this.Booleans[1, 0].Boolean, this.Booleans[1, 1].Boolean);
        }
    }
}

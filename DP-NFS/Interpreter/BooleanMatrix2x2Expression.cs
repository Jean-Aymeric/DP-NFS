using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class BooleanMatrix2x2Expression : TerminalExpression {
        public BooleanMatrix2x2 Booleans { get; set; }

        public BooleanMatrix2x2Expression(bool a0, bool a1, bool b0, bool b1) : base() {
            this.Booleans = new BooleanMatrix2x2(a0, a1, b0, b1);
        }

        public override void Interpreter(Context context) {
            context.Matrix2x2 = (BooleanMatrix2x2) this.Booleans.Clone();
        }
    }
}
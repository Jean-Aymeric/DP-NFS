using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class OrExpression : BinaryExpression {
        public OrExpression(IExpression left, IExpression right) : base("Or", left, right) {
        }

        public override void Interpreter(Context context) {
            Context leftContext = new Context();
            Context rightContext = new Context();

            this.Left.Interpreter(leftContext);
            this.Right.Interpreter(rightContext);
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    context.Matrix2x2.SetXY(i, j, leftContext.Matrix2x2.GetXY(i, j) && rightContext.Matrix2x2.GetXY(i, j));
                }
            }
        }
    }
}

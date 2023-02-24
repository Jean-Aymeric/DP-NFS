using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class NotExpression : UnaryExpression {
        public NotExpression(IExpression expression) : base(expression) { }

        public override void Interpreter(Context context) {
            this.Expression.Interpreter(context);
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    context.Matrix2x2.SetXY(i, j, !context.Matrix2x2.GetXY(i, j));
                }
            }
        }
    }

}

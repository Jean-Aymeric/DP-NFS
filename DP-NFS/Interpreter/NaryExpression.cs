using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class NaryExpression : Expression {
        protected NaryExpression() : base() {
            this.Expressions = new List<IExpression>();
        }

        protected List<IExpression> Expressions { get; set; }
    }
}

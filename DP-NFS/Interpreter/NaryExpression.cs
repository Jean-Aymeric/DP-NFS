using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class NaryExpression : Expression {
        protected NaryExpression(string name) : base(name) {
            this.Expressions = new List<IExpression>();
        }

        protected List<IExpression> Expressions { get; set; }
    }
}

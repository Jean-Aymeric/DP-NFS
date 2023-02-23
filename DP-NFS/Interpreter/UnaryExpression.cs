using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class UnaryExpression : Expression {
        protected UnaryExpression(string name, IExpression expression) : base(name) {
            this.Expression = expression;
        }

        public IExpression Expression { get; set; }
    }
}

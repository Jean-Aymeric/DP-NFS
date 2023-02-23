using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class BinaryExpression : NaryExpression {
        protected BinaryExpression(string name, IExpression left, IExpression right) : base(name) {
            this.Expressions.Add(left);
            this.Expressions.Add(right);
        }

        public IExpression Left {
            get => this.Expressions[0]; set { this.Expressions[0] = value; }
        }

        public IExpression Right {
            get => this.Expressions[1]; set { this.Expressions[1] = value; }
        }
    }
}

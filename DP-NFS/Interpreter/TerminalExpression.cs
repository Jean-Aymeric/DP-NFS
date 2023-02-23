using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class TerminalExpression : Expression {
        protected TerminalExpression(string name) : base(name) {
        }
    }
}

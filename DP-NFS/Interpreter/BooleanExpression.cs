using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class BooleanExpression : TerminalExpression {
        public bool Boolean { get; set; }
        public BooleanExpression(String booleanInString) : base("Boolean") {
            if (booleanInString.Equals("False", StringComparison.InvariantCultureIgnoreCase) || booleanInString.Equals("0", StringComparison.InvariantCultureIgnoreCase)) {
                this.Boolean = false;
            } else {
                this.Boolean = true;
            }

        }

        public override void Interpreter(Context context) { }
    }
}

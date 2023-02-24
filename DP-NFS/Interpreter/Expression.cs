using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    abstract class Expression :IExpression {
        public abstract void Interpreter(Context context);
    }
}

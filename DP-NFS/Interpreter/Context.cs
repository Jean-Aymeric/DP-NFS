using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class Context {
        public BooleanMatrix2x2 Matrix2x2 { get; set; }

        public Context() {
            this.Matrix2x2 = new BooleanMatrix2x2();
        }
    }
}

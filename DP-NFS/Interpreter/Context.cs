using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Interpreter {
    class Context {
        public BooleanMatrix2x2 Matrix2x2 { get; set; }
        public bool IsWrong { get; set; }

        public Context() {
            this.Matrix2x2 = new BooleanMatrix2x2();
            this.IsWrong = false;
        }

        public override string ToString() {
            if (this.IsWrong) {
                return "ERROR";
            }
            return this.Matrix2x2.ToString();
        }
    }
}

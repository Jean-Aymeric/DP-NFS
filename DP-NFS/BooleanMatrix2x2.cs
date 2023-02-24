using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS {
    class BooleanMatrix2x2 : ICloneable {
        public bool[,] Data { get; set; } = new bool[2, 2];
        
        public BooleanMatrix2x2(bool a0, bool a1, bool b0, bool b1) {
            this.Data = new bool[2, 2] { { a0, a1 }, { b0, b1 } };
        }

        public BooleanMatrix2x2() : this(false, false, false, false) { }

        public void SetXY(int x, int y, bool value) {
            this.Data[x, y] = value;
        }

        public bool GetXY(int x, int y) {
            return this.Data[x, y];
        }

        public override string ToString() {
            return "((" + (this.Data[0, 0]?"1":"0") + "," + (this.Data[0, 1] ? "1" : "0") + "),(" + (this.Data[1, 0] ? "1" : "0") + "," + (this.Data[1, 1] ? "1" : "0") + "))";
        }

        public object Clone() {
            return new BooleanMatrix2x2(this.Data[0, 0], this.Data[0, 1], this.Data[1, 0], this.Data[1, 1]);
        }
    }
}

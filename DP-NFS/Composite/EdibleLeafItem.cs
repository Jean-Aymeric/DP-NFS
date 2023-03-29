using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class EdibleLeafItem : LeafItem {
        public int Calories { get; set; }

        public EdibleLeafItem(string label, double weight, int calories) : base(label, weight) {
            this.Calories = calories;
        }

        public override string Label() {
            return base.Label() + "(" + this.Calories + " ca)";
        }
    }
}

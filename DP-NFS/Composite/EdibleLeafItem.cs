using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class EdibleLeafItem : LeafItem {
        private int _calories;
        public int Calories {
            get => _calories;
            set => _calories = value;
        }

        public EdibleLeafItem(string label, double weight, int calories) : base(label, weight) {
            this.Calories = calories;
        }

        public EdibleLeafItem(EdibleLeafItem other) : this(other._label, other._weight, other._calories) { }

        public override string Label() {
            return base.Label() + "(" + this.Calories + " ca)";
        }

        public override void Visit(Eater eater) {
            eater.Eat(this);
        }

        public override Item Clone() {
            return new EdibleLeafItem(this);
        }
    }
}

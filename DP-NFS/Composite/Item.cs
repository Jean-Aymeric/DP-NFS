using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    abstract class Item {
        protected String _label;
        protected double _weight;
        
        public Item(String label, double weight) {
            this._label = label;
            this._weight = weight;
        }

        public Boolean Is(String label) {
            return label.Equals(this._label);
        }

        public abstract String Label();
        public abstract double Weight();
        public abstract Item GetItemByLabel(String label);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    abstract class Item : IEnumerable<Item>, ICloneable {
        protected String _label;
        protected double _weight;
        
        public Item(String label, double weight) {
            this._label = label;
            this._weight = weight;
        }

        public Item(Item other) : this(other._label, other._weight) { }

        public Boolean Is(String label) {
            return label.Equals(this._label);
        }

        public abstract String Label();
        public abstract double Weight();
        public abstract Item GetItemByLabel(String label);

        public abstract IterableItem GetIterableItem();

        public IEnumerator<Item> GetEnumerator() {
            return this.GetIterableItem().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetIterableItem().GetEnumerator();
        }

        public abstract void Visit(Eater eater);

        public abstract Item Clone();

        object ICloneable.Clone() {
            return this.Clone();
        }
    }
}

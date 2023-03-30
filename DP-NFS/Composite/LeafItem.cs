using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class LeafItem : Item, Something {
        public LeafItem(string label, double weight) : base(label, weight) { }

        public LeafItem(Item other) : base(other) {
        }

        public override Item GetItemByLabel(string label) {
            return this.Is(label) ? this : null;
        }

        public override string Label() {
            return this._label;
        }

        public override double Weight() {
            return this._weight;
        }

        public override IterableItem GetIterableItem() {
            return new IterableItem(this);
        }

        public override void Visit(Eater eater) {
            eater.Eat((Something)this);
        }

        public override Item Clone() {
            return new LeafItem(this);
        }
    }
}

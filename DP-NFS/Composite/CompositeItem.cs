using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class CompositeItem : Item {
        public CompositeItem(string label, double weight) : base(label, weight) {
            this.Items = new List<Item>();
        }

        private List<Item> Items { get; }

        public void Add(Item item) {
            this.Items.Add(item);
        }

        public void Remove(Item item) {
            this.Items.Remove(item);
        }

        public override string Label() {
            String result = this._label + "[";
            foreach(Item item in this.Items) {
                result += item.Label() + " ";
            }
            result += "]";
            return result;
        }

        public override double Weight() {
            double result = this._weight;
            foreach (Item item in this.Items) {
                result += item.Weight();
            }
            return result;
        }

        public override Item GetItemByLabel(string label) {
            if (this.Is(label)) {
                return this;
            }
            foreach (Item item in this.Items) {
                Item result = item.GetItemByLabel(label);
                if (result != null) {
                    return result;
                }
            }
            return null;
        }

        public override IterableItem GetIterableItem() {
            IterableItem iterableItems = new(this);
            foreach (Item item in this.Items) {
                iterableItems.Merge(item.GetIterableItem());
            }
            return iterableItems;
        }

        public override void Visit(Eater eater) {
            eater.Eat(this);
        }
    }
}

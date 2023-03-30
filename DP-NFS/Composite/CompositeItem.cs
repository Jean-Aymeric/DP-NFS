using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class CompositeItem : Item {
        private List<Item> _items;
        private List<Item> Items { get => CloneList(_items); set => _items = value; }

        public CompositeItem(string label, double weight) : base(label, weight) {
            this.Items = new List<Item>();
        }

        public CompositeItem(CompositeItem other) : this(other._label, other._weight) {
            foreach (Item item in other._items) {
                this._items.Add(item.Clone());
            }
        }

        private static List<Item> CloneList(List<Item> items) {
            List<Item> result = new();
            foreach(Item item in items) {
                result.Add(item.Clone());
            }
            return result;
        }

        public void Add(Item item) {
            this._items.Add(item);
        }

        public void Remove(Item item) {
            this._items.Remove(item);
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

        public override Item Clone() {
            return new CompositeItem(this);
        }
    }
}

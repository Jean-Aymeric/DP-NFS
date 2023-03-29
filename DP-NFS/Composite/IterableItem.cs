using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class IterableItem : LinkedList<Item> {
        public IterableItem(Item item) {
            this.AddFirst(item);
        }

        public void Merge(IterableItem others) {
            foreach(Item item in others) {
                this.AddLast(item);
            }
        }
    }
}

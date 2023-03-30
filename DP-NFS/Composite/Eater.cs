using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class Eater {

        public void Eat(EdibleLeafItem item) {
            Console.WriteLine("Boulottage");
            item.Calories = 0;
        }

        public void Eat(Item item) {
            Console.WriteLine("Ce truc ne se mange pas");
        }

        public void Eat(Something item) {
            Console.WriteLine("Mince c'est une bidule");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Composite {
    class Eater {
        public void Eat(EdibleLeafItem item) {
            item.Calories = 0;
        }
    }
}

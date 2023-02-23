using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza {
    class FactoryFourCheeses : FactoryPizza {
        public FactoryFourCheeses() : base("4 fromages") {
        }

        public override IPizza Make() {
            return new FourCheeses();
        }
    }
}

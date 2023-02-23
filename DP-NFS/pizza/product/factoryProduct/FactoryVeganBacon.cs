using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.product.factoryProduct {
    class FactoryVeganBacon : FactoryProduct {
        public FactoryVeganBacon() : base("Bacon végan") {
        }

        public override IProduct Make() {
            return new VeganBacon();
        }
    }
}

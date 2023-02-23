using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.product.factoryProduct {
    class FactoryBacon : FactoryProduct {
        public FactoryBacon() : base("Bacon") {
        }

        public override IProduct Make() {
            return new Bacon();
        }
    }
}

using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.product.factoryProduct {
    class FactoryAnchovy : FactoryProduct {
        public FactoryAnchovy() : base("Anchois") {
        }

        public override IProduct Make() {
            return new Anchovy();
        }
    }
}

using DP_NFS.pizza.product.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.product.factoryProduct {
    class FactoryPepper : FactoryProduct {
        public FactoryPepper() : base("Poivron") {
        }

        public override IProduct Make() {
            return new Pepper();
        }
    }
}

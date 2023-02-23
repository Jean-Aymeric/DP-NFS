using DP_NFS.pizza.product.factoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.builder {
    class ClassicPizza : BuilderPizza {
        public override void BuildCheese(string productName) {
            this.pizza.AddProduct(FactoryProduct.Make(productName));
        }

        public override void BuildMeat(string productName) {
            this.pizza.AddProduct(FactoryProduct.Make(productName));
        }

        public override void BuildTopping(string productName) {
            this.pizza.AddProduct(FactoryProduct.Make(productName));
        }

        public override IPizza GetPizza() {
            return this.pizza;
        }

        public override void Reset(string pizzaName) {
            this.pizza = FactoryPizza.Make(pizzaName);
        }
    }
}

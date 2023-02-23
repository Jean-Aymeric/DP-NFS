using DP_NFS.pizza.product.factoryProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.builder {
    class VeganPizza : BuilderPizza {
        public override void BuildCheese(string productName) {
            this.pizza.AddProduct(FactoryProduct.Make("Fromage végan"));
        }

        public override void BuildMeat(string productName) {
            this.pizza.AddProduct(FactoryProduct.Make("Bacon végan"));
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

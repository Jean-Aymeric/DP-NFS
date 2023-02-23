using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.builder {
    interface IBuilderPizza {
        public void Reset(string pizzaName);
        public void BuildTopping(String productName);
        public void BuildCheese(String productName);
        public void BuildMeat(String productName);
        public IPizza GetPizza();
    }
}

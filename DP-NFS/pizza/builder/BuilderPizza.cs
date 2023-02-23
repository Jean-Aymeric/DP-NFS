using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza.builder {
    abstract class BuilderPizza : IBuilderPizza {
        protected IPizza pizza;

        public abstract void BuildCheese(string productName);
        public abstract void BuildMeat(string productName);
        public abstract void BuildTopping(string productName);
        public abstract IPizza GetPizza();
        public abstract void Reset(string pizzaName);
    }
}

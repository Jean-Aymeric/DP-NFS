using DP_NFS.liquid;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Drinker coffeDrinker = new CoffeeDrinker();
            Drinker teaDrinker = new TeaDrinker();

            coffeDrinker.Drink(FactoryLiquid.factoryCoffee);
            coffeDrinker.Drink(FactoryLiquid.factoryDecaffeinated);
            teaDrinker.Drink(FactoryLiquid.factoryTea);
        }
    }
}

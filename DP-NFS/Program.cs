using DP_NFS.liquid;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Drinker coffeDrinker = new CoffeeDrinker();
            Drinker teaDrinker = new TeaDrinker();
            coffeDrinker.Drink(FactoryLiquid.FACTORYCOFFEE);
            coffeDrinker.Drink(FactoryLiquid.FACTORYDECAFFEINATED);
            teaDrinker.Drink(FactoryLiquid.FACTORYCOFFEE);
        }
    }
}

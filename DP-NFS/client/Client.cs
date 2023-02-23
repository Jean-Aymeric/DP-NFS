using DP_NFS.pizza;
using DP_NFS.pizza.builder;
using System;


namespace DP_NFS.client {
    class Client {
        public void Eat(IBuilderPizza builderPizza) {

            builderPizza.Reset(FactoryPizza.GetMakings()[FactoryPizza.GetMakings().Count - 1]);
            builderPizza.BuildCheese("Emmental");
            builderPizza.BuildMeat("Bacon");
            builderPizza.BuildTopping("Poivron");
            IPizza pizza = builderPizza.GetPizza();
            Console.WriteLine("Je mange une " + pizza.Name);
        }
    }
}

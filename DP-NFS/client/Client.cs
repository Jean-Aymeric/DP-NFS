using DP_NFS.pizza;
using System;


namespace DP_NFS.client {
    class Client {
        public void Eat() {
            Console.WriteLine("Je mange une " + FactoryMenu.MakePizza(FactoryMenu.GetMakingsPizza()[FactoryMenu.GetMakingsPizza().Count - 1]).Name +
                " en buvant un " + FactoryMenu.MakePizza(FactoryMenu.GetMakingsDrink()[FactoryMenu.GetMakingsDrink().Count - 1]).Name + " frais.");
        }
    }
}

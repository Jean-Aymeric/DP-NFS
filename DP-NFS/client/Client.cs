using DP_NFS.pizza;
using System;


namespace DP_NFS.client {
    class Client {
        public void Eat() {
            Console.WriteLine("Je mange une " + FactoryPizza.Make(FactoryPizza.GetMakings()[FactoryPizza.GetMakings().Count-1]).Name);
        }
    }
}

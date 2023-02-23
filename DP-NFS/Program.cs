using DP_NFS.client;
using DP_NFS.pizza;
using DP_NFS.pizza.builder;
using DP_NFS.pizza.product.factoryProduct;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            new FactoryAnchovy();
            new FactoryBacon();
            new FactoryEmmental();
            new FactoryGorgonzola();
            new FactoryMissingProduct();
            new FactoryPepper();
            new FactoryVeganBacon();
            new FactoryVeganCheese();

            new FactoryFourCheeses();
            new FactoryCalzone();
            new FactoryRoman();


            Client client = new Client();
            client.Eat(new ClassicPizza());
            client.Eat(new VeganPizza());
        }
    }
}

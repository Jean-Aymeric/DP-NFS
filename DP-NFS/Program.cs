using DP_NFS.client;
using DP_NFS.pizza;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Client client = new Client();
            new FactoryFourCheeses();
            client.Eat();
            new FactoryCalzone();
            client.Eat();
            new FactoryRoman();
            client.Eat();
        }
    }
}

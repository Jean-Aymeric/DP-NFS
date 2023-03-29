using DP_NFS.Composite;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            CompositeItem cart = new CompositeItem("Panier", 1.1);
            CompositeItem box = new CompositeItem("Boite", 0.3);
            CompositeItem tinyBox = new CompositeItem("Mini boite", 0.2);
            LeafItem apple = new LeafItem("Pomme", 0.75);
            LeafItem cherry = new LeafItem("Cerise", 0.09);
            cart.Add(box);
            cart.Add(apple);
            box.Add(cherry);
            box.Add(tinyBox);
            tinyBox.Add(new LeafItem("Bague", 0.1));
            tinyBox.Add(new LeafItem("Boucles d'oreille", 0.25));
            Console.WriteLine(cart.Label());
            Console.WriteLine(cart.Weight());
            Console.WriteLine(cart.GetItemByLabel("Cerise").Label());
        }
    }
}

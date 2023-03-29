using DP_NFS.Composite;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            CompositeItem cart = new CompositeItem("Panier", 1.1);
            CompositeItem box = new CompositeItem("Boite", 0.3);
            CompositeItem tinyBox = new CompositeItem("Mini boite", 0.2);
            EdibleLeafItem apple = new EdibleLeafItem("Pomme", 100, 52);
            EdibleLeafItem cherry = new EdibleLeafItem("Cerise", 100, 50);
            EdibleLeafItem mars = new EdibleLeafItem("Mars", 100, 450);
            cart.Add(box);
            cart.Add(apple);
            cart.Add(mars);
            box.Add(cherry);
            box.Add(tinyBox);
            tinyBox.Add(new LeafItem("Bague", 0.1));
            tinyBox.Add(new LeafItem("Boucles d'oreille", 0.25));
            Console.WriteLine(cart.Label());

            Eater jad = new();
            foreach (Item item in cart) {
                if (item.GetType().Name == "EdibleLeafItem") {
                    jad.Eat((EdibleLeafItem)item);
                }
            }

            Console.WriteLine(cart.Label());
        }
    }
}

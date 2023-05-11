using DP_NFS.liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS {
    internal class CoffeeDrinker : Drinker {
        public override void Drink(IFactoryLiquid factoryLiquid) {
            Console.WriteLine("Je bois du " + factoryLiquid.Make().Name);
        }
    }
}

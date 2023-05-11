using DP_NFS.liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS {
    internal class TeaDrinker : Drinker {
        public override void Drink(FactoryLiquid factoryLiquid) {
            Console.WriteLine("Je bois du " + factoryLiquid.Make().Name);
        }
    }
}

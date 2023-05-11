using DP_NFS.liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS {
    internal abstract class Drinker {
        public abstract void Drink(IFactoryLiquid factoryLiquid);
    }
}

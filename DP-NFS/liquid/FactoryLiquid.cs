using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.liquid
{
    internal abstract class FactoryLiquid : IFactoryLiquid {
        public static IFactoryLiquid FACTORYCOFFEE = new ProxyFactoryLiquid(new FactoryCoffee());
        public static IFactoryLiquid FACTORYTEA = new ProxyFactoryLiquid(new FactoryTea());
        public static IFactoryLiquid FACTORYDECAFFEINATED = new ProxyFactoryLiquid(new FactoryDecaffeinated());

        public abstract Liquid Make();
    }
}

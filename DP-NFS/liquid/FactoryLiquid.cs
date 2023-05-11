using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.liquid
{
    internal abstract class FactoryLiquid
    {
        public static FactoryLiquid FACTORYCOFFEE = new FactoryCoffee();
        public static FactoryLiquid FACTORYTEA = new FactoryTea();
        public static FactoryLiquid FACTORYDECAFFEINATED = new FactoryDecaffeinated();

        public abstract Liquid Make();
    }
}

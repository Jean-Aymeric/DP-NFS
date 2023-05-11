using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.liquid
{
    internal class FactoryCoffee : FactoryLiquid
    {
        public override Liquid Make()
        {
            return new Coffee();
        }
    }
}

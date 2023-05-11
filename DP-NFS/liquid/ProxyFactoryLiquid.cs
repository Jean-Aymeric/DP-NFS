using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.liquid {
    internal class ProxyFactoryLiquid : IFactoryLiquid {
        private IFactoryLiquid realFactory;
        private int counter = 0;

        public ProxyFactoryLiquid(IFactoryLiquid realFactory) {
            this.realFactory = realFactory;
        }

        public Liquid Make() {
            Console.WriteLine(++counter);
            return this.realFactory.Make();
        }
    }
}

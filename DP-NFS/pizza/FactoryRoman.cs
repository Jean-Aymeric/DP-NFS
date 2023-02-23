using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza {
    class FactoryRoman : FactoryPizza {
        public FactoryRoman() : base("Romaine") {

        }

        public override IDrink Make() {
            return new Romaine();
        }
    }
}

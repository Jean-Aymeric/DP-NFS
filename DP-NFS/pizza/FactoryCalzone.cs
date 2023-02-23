using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.pizza {
    class FactoryCalzone : FactoryPizza {
        public FactoryCalzone() : base("Calzone") {

        }

        public override IDrink Make() {
            return new Calzone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Visitor {
    public class Country : State {
        public Country(string designation, int population, String leader) {
            this.Designation = designation;
            this.Population = population;
            this.Leader = leader;
        }

        public String Designation { get; }
        public int Population { get; }
        public String Leader { get;  }
        public void Visit(Screen screen) {
            screen.Display(this);
        }
    }
}

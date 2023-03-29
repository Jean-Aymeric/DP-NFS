using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Visitor {
    public class Continent : State {
        public Continent(string designation, int population, int nbCountries) {
            this.Designation = designation;
            this.Population = population;
            this.NbCountries = nbCountries;
        }

        public String Designation { get; }
        public int Population { get; }
        public int NbCountries { get;  }

        public void Visit(Screen screen) {
            screen.Display(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Visitor {
    public class Screen {
        private void DisplayStart(State state) {
            Console.Write(state.Designation + "(" + state.Population + ") ");
        }

        public void Display(State state) {
            state.Visit(this);
        }

        public void Display(FantasyState state) {
            this.DisplayStart(state);
            Console.WriteLine("Population majoritairement " + FantasyState.RaceToString(state.PrincipalRace));
        }

        public void Display(Continent state) {
            this.DisplayStart(state);
            Console.WriteLine("Pays : " + state.NbCountries.ToString());
        }

        public void Display(Country state) {
            this.DisplayStart(state);
            Console.WriteLine("Leader " + state.Leader);
        }
    }
}

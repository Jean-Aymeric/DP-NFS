using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Visitor {
    public class FantasyState : State {
        public FantasyState(string designation, int population, Race principalRace) {
            this.Designation = designation;
            this.Population = population;
            this.PrincipalRace = principalRace;
        }

        public String Designation { get; }
        public int Population { get; }
        public Race PrincipalRace { get;  }

        public static String RaceToString(Race race) {
            switch (race) {
                case Race.Dwarf:
                    return "Nain";
                case Race.Elf:
                    return "Elf";
                case Race.Human:
                    return "Humain";
                case Race.Orc:
                    return "Orc";
                default:
                    return "Unknown";
            }
        }

        public void Visit(Screen screen) {
            screen.Display(this);
        }
    }
}

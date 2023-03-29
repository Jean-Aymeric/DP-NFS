using DP_NFS.Visitor;
using System;
using System.Collections;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Screen screen = new();
            ArrayList states = new();
            states.Add(new FantasyState("Monde magique", 156, Race.Dwarf));
            states.Add(new Continent("Europe", 10000, 27));
            states.Add(new Country("France", 1000, "Macron"));

            foreach(State state in states) {
                screen.Display(state);
            }
        }
    }
}

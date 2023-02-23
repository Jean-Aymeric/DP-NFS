using System;

namespace DP_NFS.pizza {
    internal abstract class Pizza : IPizza {
        public String Name { get; set; }

        public Pizza(string name) {
            Name = name;
        }
    }
}

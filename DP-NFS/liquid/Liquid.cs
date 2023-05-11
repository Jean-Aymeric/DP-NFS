using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.liquid
{
    internal abstract class Liquid
    {
        public string Name { get; set; }
        public Liquid(string name)
        {
            Name = name;
        }
    }
}

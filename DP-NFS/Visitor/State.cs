using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.Visitor {
    public interface State {
        String Designation { get; }
        int Population { get; }
        void Visit(Screen screen);
    }
}

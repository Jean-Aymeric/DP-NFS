using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message {
    internal abstract class TextValidator {
        public static bool IsOk(Message message) {
            return true;
        }
    }
}

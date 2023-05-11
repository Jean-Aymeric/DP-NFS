using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message {

    internal abstract class TextValidator {

        private static Handler handler = new HandlerChain();

        public static bool IsOk(Message message) {
            return handler.Handle(message);
        }
    }
}

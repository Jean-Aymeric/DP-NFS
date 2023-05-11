using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal class HandlerCaca : AbstractHandler
    {
        public override bool Handle(Message message)
        {
            if (message.Text.Contains("caca", StringComparison.OrdinalIgnoreCase)){
                return false;
            }
            return this.next.Handle(message);
        }
    }
}

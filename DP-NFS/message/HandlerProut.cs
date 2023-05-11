using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal class HandlerProut : AbstractHandler
    {
        public override bool Handle(Message message)
        {
            if (message.Text.Contains("prout", StringComparison.OrdinalIgnoreCase)){
                return false;
            }
            return this.next.Handle(message);
        }
    }
}

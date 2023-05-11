using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal class HandlerEmpty : AbstractHandler
    {
        public override bool Handle(Message message)
        {
            if (message.Text.Equals("")){
                return false;
            }
            return this.next.Handle(message);
        }
    }
}

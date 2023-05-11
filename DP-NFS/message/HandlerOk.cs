using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal class HandlerOk : AbstractHandler
    {
        public override bool Handle(Message message)
        {
            return true;
        }
    }
}

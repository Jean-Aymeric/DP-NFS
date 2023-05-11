using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal interface Handler
    {
        void setNext(Handler next);
        bool Handle(Message message);

        Handler getNext();

    }
}

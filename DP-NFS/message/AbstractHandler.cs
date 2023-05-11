using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal abstract class AbstractHandler : Handler
    {
        public void setNext(Handler next)
        {
            this.next = next;
        }

        public abstract bool Handle(Message message);

        protected Handler next;

        public Handler getNext() { 
            return this.next; 
        }
    }
}

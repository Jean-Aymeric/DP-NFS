using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_NFS.message
{
    internal class HandlerChain : AbstractHandler
    {
        public override bool Handle(Message message)
        {
            return this.next.Handle(message);
        }

        public HandlerChain() {
            this.setNext(new HandlerProut());
            Handler temp = this.next;
            temp.setNext(new HandlerCaca());
            temp = temp.getNext();
            temp.setNext(new HandlerThree());
            temp = temp.getNext();
            temp.setNext(new HandlerEmpty());
            temp = temp.getNext();
            temp.setNext(new HandlerOk());
        }
    }
}

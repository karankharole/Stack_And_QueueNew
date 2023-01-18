using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueNew
{
    internal class Node
    {

        internal readonly string value;
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}

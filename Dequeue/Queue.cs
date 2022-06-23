using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Queue
    {
        Linkedlist linkedlist;

        public Queue()
        {
            linkedlist = new Linkedlist();
        }


        public void Enqueue(Node node)
        {
            linkedlist.AppendNode(node);
        }
        public void DisplayQueue()
        {
            Console.WriteLine("Queue :");
            linkedlist.Display();
        }


        public void Top()
        {
            var val = linkedlist.Head;
            Console.WriteLine(val.data);
        }

        public void Deenque()
        {
            linkedlist.DeleteNodeAtLast();
        }

    }
}

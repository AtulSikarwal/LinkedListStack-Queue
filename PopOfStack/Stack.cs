using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Stack
    {
        Linkedlist linkedlist;

        public Stack()
        {
            linkedlist = new Linkedlist();
        }
        public void Push(Node node)
        {
            linkedlist.AddNode(node);

        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack: ");
            linkedlist.Display();
        }
        public void Top()
        {
            linkedlist.DeleteNodeAtFirst();
        }
        
    }
}

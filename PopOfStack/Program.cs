namespace DSA
{
    public class Program
    {   
        public static void Main(String[] args)
        {
            Linkedlist Link = new Linkedlist();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(95);



          //  Stack
            Stack stack = new Stack();

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();
            stack.Top();
            stack.DisplayStack();




            //Queue
            Queue queue = new Queue();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.DisplayQueue();
            queue.Deenque();
            queue.DisplayQueue();

        }
    }
}
namespace DSA
{
    public class Program
    {   
        public static void Main(String[] args)
        {
          
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(95);






            //Queue
            Queue queue = new Queue();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.DisplayQueue();
          
            queue.DisplayQueue();

        }
    }
}

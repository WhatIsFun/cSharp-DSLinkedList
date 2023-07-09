namespace cSharp_DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(100);
            linkedList.Insert(90);
            linkedList.Insert(30);
            linkedList.Insert(40);

            linkedList.Display();


            linkedList.Remove(90);
            Console.WriteLine("After deleting...");
            linkedList.Display();
        }
    }
}
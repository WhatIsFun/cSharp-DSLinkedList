namespace cSharp_DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(100);
            linkedList.Insert(90);
            //linkedList.Insert(30);
            //linkedList.Insert(40);

            linkedList.Display();


            linkedList.Remove(90);
            Console.WriteLine("After deleting...");
            linkedList.Display();

            Console.WriteLine("Inserting by Posision");

            linkedList.InsertByPosition(40, 1);
            linkedList.InsertByPosition(20, 2);
            linkedList.InsertByPosition(30, 3);
            linkedList.InsertByPosition(10, 4);
            linkedList.InsertByPosition(200, 7);
            linkedList.InsertByPosition(500, -1);

            linkedList.Display();


        }
    }
}
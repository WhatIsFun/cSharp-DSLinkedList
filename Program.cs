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

            linkedList.Display();
        }
    }
}
namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InserAtParticularPosition(2,51);
            list.RemoveFirstNode();
            list.Display();
        }
    }
}
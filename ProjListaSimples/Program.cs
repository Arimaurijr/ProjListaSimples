using ProjListaSimples;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaItem list = new ListaItem();
        Item item;
        Random r = new Random();
        list.Print();
        Console.ReadLine();

        do
        {
            //Console.Clear();
            int x = r.Next(50);
            Console.WriteLine(x);

            item = new(x);
            list.Insert(item);
            list.Print();
            Console.ReadLine();

        } while (true);



    }
}
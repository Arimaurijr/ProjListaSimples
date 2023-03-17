using ProjListaSimples;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaItem list = new ListaItem();

        Item item1 = new Item(21);
        Item item2 = new Item(22);
        Item item3 = new Item(23);
        Item item4 = new Item(24);  
        Item item5 = new Item(25);
        
        list.Insert(item1);
        list.InsertLast(item5);
        list.Print();

        Console.WriteLine();


    }
}
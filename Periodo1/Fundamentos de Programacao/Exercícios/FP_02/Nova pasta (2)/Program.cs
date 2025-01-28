internal class Program
{
    private static void Main(string[] args)
    {
        double preco1 = 100.5;
        double preco2 = 1.2;
        string descricao1 = "coca-cola";
        string descricao2 = "pepsi";

        Console.WriteLine("{0,-10} {1,7:N2}", descricao1, preco1);
        Console.WriteLine("{0,-10} {1,7:N2}", descricao2, preco2);

        Console.WriteLine("{0,-10} {1,7:N2}", "Total:", preco1+preco2);
        Console.WriteLine("1","2");
        
    }
}
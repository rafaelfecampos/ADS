internal class Program
{
    private static void Main(string[] args)
    {
        double a = 1.346728;

        Console.WriteLine("Valor x com 1 casa decimal: {0:N1}", a);
        Console.WriteLine("Valor x com 2 casas decimais: {0:N2}", a);
        Console.WriteLine("Valor x com 3 casas decimais: {0:N3}", a);
        Console.WriteLine("Valor x com 5 casas decimais: {0:N5}", a);
        Console.ReadKey();
    }
}
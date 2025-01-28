internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor do produto: R$");
        double preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o percentual do acréscimo: ");
        double acréscimo = Convert.ToDouble(Console.ReadLine());
        double precoFinal = CalcAcrescimo(preco, acréscimo);
        Console.WriteLine("Preço final do produto: {0:N2}", precoFinal);
        Console.ReadKey();
    }
    static double CalcAcrescimo(double preco, double acréscimo)
    {
        double finalPreco= preco+(preco*(acréscimo/100));
        return finalPreco;
    }
}
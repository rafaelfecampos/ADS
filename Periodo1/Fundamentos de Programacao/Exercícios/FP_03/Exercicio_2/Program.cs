internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor do produto: R$");
        double preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o percentual do desconto: ");
        double desconto = Convert.ToDouble(Console.ReadLine());
        double precoFinal = CalcDesconto(preco, desconto);
        Console.WriteLine("Preço final do produto: {0:N2}", precoFinal);
        Console.ReadKey();
    }
    static double CalcDesconto(double preco, double desconto)
    {
        double finalPreco= preco-(preco*(desconto/100));
        return finalPreco;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Peso em kg:");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura em metros:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.Write("O imc do indivíduo é: {0}", imc);
    }
}
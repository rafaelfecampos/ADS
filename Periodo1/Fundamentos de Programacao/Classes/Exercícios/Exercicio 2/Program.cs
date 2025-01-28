internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        Console.Write("Qual o seu peso em kg: ");
        pessoa1.Peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Qual a sua altura em metros: ");
        pessoa1.Altura = Convert.ToDouble(Console.ReadLine());
    }
}
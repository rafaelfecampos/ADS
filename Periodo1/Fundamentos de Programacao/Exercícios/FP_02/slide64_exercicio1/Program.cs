internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Insira o dia do seu nascimento: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o mês do seu nascimento: ");
        string mes = Console.ReadLine();
        Console.Write("Insira o ano do seu nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
    }
}
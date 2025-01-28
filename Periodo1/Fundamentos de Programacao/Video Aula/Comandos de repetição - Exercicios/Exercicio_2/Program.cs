internal class Program
{
    static int LerIdade()
    {
        int idade;
        Console.Write("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        while (idade <= 0 || idade >= 130)
        {
            Console.WriteLine("Idade inválida!");
            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
        }
        return idade;
    }
    private static void Main(string[] args)
    {
        int idade;
        idade = LerIdade();
        Console.WriteLine("Sua idade é {0}", idade);
    }
}
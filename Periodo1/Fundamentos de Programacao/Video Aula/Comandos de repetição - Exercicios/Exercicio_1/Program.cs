internal class Program
{
    private static void Main(string[] args)
    {
        string frase;
        int quant;
        Console.Write("Escreva uma frase: ");
        frase = Console.ReadLine();
        Console.Write("Quantas vezes a frase será repetida?\nR: ");
        quant = Convert.ToInt32(Console.ReadLine());
        if (quant <= 0)
        {
            Console.WriteLine("Quantidade de repetições inválida!");
        }
        else
        {
            Console.WriteLine("Resposta:");
            while(quant!=0)
            {
                Console.WriteLine(frase);
                quant=quant-1;
            }
        }
        Console.ReadKey();
    }
}
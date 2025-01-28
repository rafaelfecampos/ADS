internal class Program
{
    private static void Main(string[] args)
    {
        //usario informa uma sequencia de numero inteiro para ser calculado a soma desta sequencia conforme for sendo digitado até ser digitado 0.
        int soma = 0, num;
        Console.Write("Escreva um numero inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            soma=soma+num;
            Console.Write("Escreva um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Soma total: {0}", soma);
    }
}
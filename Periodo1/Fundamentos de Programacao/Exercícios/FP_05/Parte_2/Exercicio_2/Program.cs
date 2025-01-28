internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe 10 valores: ");
        double num, maior, menor;
        int cont = 1;
        Console.Write("n{0}: ", cont);
        num = Convert.ToDouble(Console.ReadLine());
        maior = menor = num;
        while (cont < 10)
        {
            Console.Write("n{0}: ", cont + 1);
            num = Convert.ToDouble(Console.ReadLine());
            if (num > maior)
            {
                maior = num;
            }
            else if (num < menor)
            {
                menor = num;
            }
            cont++;
        }
        Console.WriteLine("Maior número inserido: {0}", maior);
        Console.WriteLine("Menor número inserido: {0}", menor);

    }
}
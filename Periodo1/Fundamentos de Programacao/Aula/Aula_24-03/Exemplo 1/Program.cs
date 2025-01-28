internal class Program
{
    private static void Main(string[] args)
    {
        //usuário informa uma sequência de número inteiro para ser calculado o quadrado do numero até ser inserido o número 0
        int num, quad;
        Console.Write("Digite um numero inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            quad = num * num;
            Console.WriteLine("O Quadrado de {0} é {1}", num, quad);
            Console.Write("Digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
}
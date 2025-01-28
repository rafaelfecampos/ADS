internal class Program
{
    private static void Main(string[] args)
    {
        //contar a quantidade de numeros em uma sequencia de numeros inteiros informada pelo usuário.
        int num, cont;
        cont = 0;
        Console.Write("Digite um numero inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            cont++;
            Console.Write("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Numero de elemntos: {0}", cont);
    }
}
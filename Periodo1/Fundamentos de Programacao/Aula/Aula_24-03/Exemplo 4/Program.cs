internal class Program
{
    private static void Main(string[] args)
    {
        //imprimir a media da sequencia de numeros digitada pelo usuario
        int num, cont;
        double soma, media;
        cont = 0;
        soma = 0;
        Console.Write("Digite um numero inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            cont++;
            soma=soma+num;
            Console.Write("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        media = soma/cont;
        Console.Write("Média: {0}", media);
    }
}
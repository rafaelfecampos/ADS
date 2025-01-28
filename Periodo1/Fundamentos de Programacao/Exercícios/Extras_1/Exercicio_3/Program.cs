/*Faça uma função que leia números reais informados pelo usuário enquanto o número lido for negativo. Assim que for lido um número não negativo, a função deve retornar o número lido. Note que esta função não recebe parâmetros. No método Main, use a sua função para ler um número real não negativo.*/

internal class Program
{
    static double LerNumeroNaoNegativo()
    {
        double n;
        Console.Write("Escreva um número real negativo: ");
        n = Convert.ToDouble(Console.ReadLine());
        
        while (n < 0)
        {
            Console.Write("Escreva um número real negativo: ");
            n= Convert.ToDouble(Console.ReadLine());
        }
        return n;
    }
    private static void Main(string[] args)
    {
        double nLido = LerNumeroNaoNegativo();
        Console.WriteLine("Número não negativo escrito: {0}",nLido);
    }
}
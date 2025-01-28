/* Faça uma função que receba por parâmetro um inteiro N, leia N números inteiros e retorne a média aritmética dos números positivos lidos. No método principal (Main), peça para o usuário informar quantos números ele deseja ler, passe essa informação por parâmetro para a função criada e imprima o retorno da função com 3 casas decimais.*/

internal class Program
{
    static double LerNumCalMedia(int n)
    {
        int cont1, cont2;
        double soma,media=1;
        cont1=0;
        cont2=0;
        soma=0;

        while(cont1 <n)
        {
            Console.Write("Escreva um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                soma=soma+num;
                cont2++;
            }
            cont1++;
        }
        media = soma/cont2;
        return media;
    }
    private static void Main(string[] args)
    {
        Console.Write("Quatida de números inteiros a serem informados: ");
        int quant = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Média aritmética dos númeors positivos lidos: {0:N3}", LerNumCalMedia(quant));
    }
}
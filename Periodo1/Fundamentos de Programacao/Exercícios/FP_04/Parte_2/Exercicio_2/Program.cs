/*Faça um programa para ler dois números reais e verificar se ambos são maiores que zero. Caso positivo, informar “Valores são válidos”. Caso contrário, informar “Valores inválidos”.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe dois números reais: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (n1 > 0 && n2 > 0)
        {
            Console.WriteLine("Valores são válidos");
        }
        else
        {
            Console.WriteLine("Valores inválidos");
        }
    }
}
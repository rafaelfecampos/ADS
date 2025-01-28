/*Faça um programa para ler um caractere e imprimir as seguintes mensagens, segundo o caso:
• “Sinal de menor”
• “Sinal de maior”
• “Sinal de igual”
• “Outro caractere”*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Insira um caractere: ");
        char a = Convert.ToChar(Console.ReadLine());

        if (a == '<')
        {
            Console.WriteLine("Sinal de menor");
        }
        else if (a == '>')
        {
            Console.WriteLine("Sinal de maior");
        }
        else if (a == '=')
        {
            Console.WriteLine("Sinal de igual");
        }
        else
        {
            Console.WriteLine("Outro caractere");
        }
        Console.ReadKey();
    }
}
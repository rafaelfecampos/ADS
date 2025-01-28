/*Fazer um algoritmo para ler dois números e um dos símbolos das operações: +, -, * e /. Imprimir o resultado da operação efetuada sobre os números lidos.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe o primeiro número da operação: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o segundo número da operação: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o sinal da operação: ");
        char sinal = Convert.ToChar(Console.ReadLine());

        if (sinal == '+')
        {
            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
        }
        else if (sinal == '-')
        {
            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
        }
        else if (sinal == '*')
        {
            Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
        }
        else
        {
            Console.WriteLine("{0} / {1} = {2:N2}", n1, n2, n1 / n2);
        }
    }
}
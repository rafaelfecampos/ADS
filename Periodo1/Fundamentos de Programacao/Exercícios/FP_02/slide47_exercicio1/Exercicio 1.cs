/*Faça um programa que lê uma temperatura em graus Celsius e apresenta-a convertida em graus Fahrenheit. A  Fórmula de conversão: F ← (9*C+160)/5*/
internal class Program
{
    private static void Main(string[] args)
    {
        double fahrenheit, celsius;

        Console.Write("Temperatura em Fahrenheit:");
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        celsius = (5*fahrenheit-160)/9;
        Console.Write("A temperatura {0}°F em celsius é:{1}°C",fahrenheit,celsius);
        
        }
}
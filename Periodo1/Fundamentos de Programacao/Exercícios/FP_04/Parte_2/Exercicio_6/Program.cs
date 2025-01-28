/*Elabore um programa que, dada a idade de um nadador, classifique-o em uma das seguintes categorias:
• infantil A = 5 – 7 anos
• infantil B = 8 – 10 anos
• juvenil A = 11 – 13 anos
• juvenil B = 14 – 17 anos
• adulto = 18 – 30 anos
• sênior = maiores de 30 anos*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 5 && idade <= 7)
        {
            Console.Write("Infantil A");
        }
        else if (idade >= 8 && idade <= 10)
        {
            Console.Write("Infantil B");
        }
        else if (idade >= 11 && idade <= 13)
        {
            Console.Write("Juvenil A");
        }
        else if (idade >= 14 && idade <= 17)
        {
            Console.Write("Juvenil B");
        }
        else if (idade >= 18 && idade <= 30)
        {
            Console.Write("Adulto");
        }
        else if (idade > 30)
        {
            Console.Write("Sênior");
        }
        else
        {
            Console.Write("Não existe categoria");
        }
    }
}
/*Desenvolver um algoritmo para ler o número do dia da semana e imprimir o seu respectivo nome por extenso. Considerar o número 1 como domingo, 2 para segunda etc. Caso o dia da semana não exista (menor do que 1 ou maior do que 7), exibir a mensagem “Dia da semana inválido".*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número correspondente a um dia da semana: ");
        int diaSemana = Convert.ToInt32(Console.ReadLine());

        if (diaSemana < 1 || diaSemana > 7)
        {
            Console.WriteLine("Dia da semana inválido");
        }
        else if (diaSemana == 1)
        {
            Console.WriteLine("Domingo");
        }
        else if (diaSemana == 2)
        {
            Console.WriteLine("Segunda-feira");
        }
        else if (diaSemana == 3)
        {
            Console.WriteLine("Terça-feira");
        }
        else if (diaSemana == 4)
        {
            Console.WriteLine("Quarta-feira");
        }
        else if (diaSemana == 5)
        {
            Console.WriteLine("Quinta-feira");
        }
        else if (diaSemana == 6)
        {
            Console.WriteLine("Sexta-feira");
        }
        else if (diaSemana == 7)
        {
            Console.WriteLine("Sábado");
        }
        Console.ReadKey();
    }
}
/*Escreva um algoritmo que leia a matrícula de um aluno e suas três notas.
Calcule a média ponderada do aluno, considerando que o peso para a maior
nota seja 4 e para as duas restantes, 3. Mostre ao final a média calculada e
uma mensagem "APROVADO" se a média for maior ou igual a 5 e
"REPROVADO" se a média for menor que 5. Repita a operação até que o
código lido seja negativo. */

internal class Program
{
    private static void Main(string[] args)
    {
        int matricula;
        double nota1, nota2, nota3;
        Console.Write("Matricula do aluno: ");
        matricula = Convert.ToInt32(Console.ReadLine());
        while (matricula >= 0)
        {
            Console.Write("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            if (VerificarNotas(nota1, nota2, nota3))
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            Console.Write("Matricula do aluno: ");
            matricula = Convert.ToInt32(Console.ReadLine());
        }
        if (matricula < 0)
        {
            Console.WriteLine("Matrícula inválida!");
        }
    }
    static bool VerificarNotas(double a, double b, double c)
    {
        double media;
        if (a > b && a > c)
        {
            media = (a * 4 + b * 3 + c * 3) / (4+3+3);
        }
        else if (b > a && b > c)
        {
            media = (b * 4 + a * 3 + c * 3) / (4+3+3);
        }
        else
        {
            media = (c * 4 + b * 3 + a * 3) / (4+3+3);
        }
        Console.WriteLine("Média: {0}", media);
        return (media >= 5);
    }
}
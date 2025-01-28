/*Considerando o critério de aprovação de uma disciplina que determina que um aluno está aprovado se a média
ponderada de suas três provas for maior ou igual a 5.0, onde a média é dada pela fórmula:
Média = (P1 + P2 + 2.0 * P3) / 4.0
(a) Escreva uma função que receba como parâmetros as notas das duas primeiras provas de um aluno (P1 e P2) e retorne a 
nota mínima que o aluno precisa tirar na terceira prova para que seja aprovado.
(b) Escreva um programa em C# completo que leia do teclado as duas primeiras notas de um aluno, calcule e imprima a 
nota mínima que o aluno precisa tirar na P3 para que seja aprovado. Este programa deve fazer uso da função
do item anterior.*/



//Letra a)
/*static double calculoNota(double p1, double p2)
{
    double notaMinima;
    notaMinima = 2*((-1)*((p1+p2)/4)+5);
    return notaMinima;
}*/

//Letra b)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a nota da primeira prova: ");
        double prova1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota da segunda prova: ");
        double prova2 = Convert.ToDouble(Console.ReadLine());

        double notaP3 = calculoNota(prova1, prova2);

        Console.WriteLine("A nota mínima necessária que o aluno deverá tirar na prova 3 é: {0:N1}", notaP3);
    }
    static double calculoNota(double p1, double p2)
    {
        double notaMinima;
        notaMinima = 2 * ((-1) * ((p1 + p2) / 4) + 5);
        return notaMinima;
    }
}
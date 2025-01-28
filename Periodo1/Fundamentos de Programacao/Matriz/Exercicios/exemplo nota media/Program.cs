using System;
using System.Text;

class Program
{
    static void LeMatriz(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento {0}, {1}: ", i, j);
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    const int TAM = 5;

    static void Main(string[] args)
    {
        string[] alunos = new string[TAM];0
        double[,] notas = new double[TAM,2];
        double[] medias = new double[TAM];
        double somaMedias = 0.0, somaNotas;

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Aluno {0} de {1}:", i + 1, alunos.Length);
            Console.Write("  Nome: ");
            alunos[i] = Console.ReadLine();

            somaNotas = 0;

            for (int j = 0; j < notas.GetLength(1); j++)
            {
                Console.Write("  Nota {0}/{1}: ", j + 1, notas.GetLength(1));
                notas[i, j] = Convert.ToDouble(Console.ReadLine());

                somaNotas += notas[i,j];
            }

            medias[i] = somaNotas / notas.GetLength(1);
        }

        somaMedias = 0;

        for (int i = 0; i < medias.Length; i++)
        {
            somaMedias += medias[i];
        }

        double notaMedia = somaMedias / medias.Length;

        Console.WriteLine();

        Console.WriteLine("Média da turma: {0}", notaMedia);

        Console.WriteLine("\nMédia de cada aluno: ");

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("  {0}: {1}", alunos[i], medias[i]);
        }

        Console.WriteLine("\nAlunos com média acima da média da sala: ");

        for (int i = 0; i < medias.Length; i++)
        {
            if (medias[i] > notaMedia)
            {
                Console.WriteLine("  {0}", alunos[i]);
            }
        }
    }
}
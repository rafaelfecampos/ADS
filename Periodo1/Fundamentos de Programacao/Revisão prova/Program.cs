/*Questão 1: Faça uma função que receba por parâmetro uma string. Se a primeira letra da string for uma vogal, a função deve retornar a string convertida para letras maiúsculas. Caso contrário, a função deve retornar a string convertida para letras minúsculas
Exemplos:
- Para a string “Teste 123” deve ser retornado “teste 123”
- Para a string “Este 123” deve ser retornado “ESTE 123”*/

//REFAZER QUESTÃO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/*using System.Text;
internal class Program
{
    static bool EhVogal(char c)
    {
        string vogais = "aeiouAEIOU";
        for (int i = 0; i < vogais.Length; i++)
        {
            if (vogais[i] == c)
                return true;
        }
        return false;
    }
    static string ConverterMaiusculas(string texto)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 'a' && texto[i] <= 'z')
            {
                sb.Append(Convert.ToChar(texto[i] + 'A' - 'a'));
            }
            else
            {
                sb.Append(texto[i]);
            }
        }
        return sb.ToString();
    }
    static string ConverterMinusculas(string texto)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 'A' && texto[i] <= 'Z')
            {
                sb.Append(Convert.ToChar(texto[i] - 'A' + 'a'));
            }
            else
            {
                sb.Append(texto[i]);
            }
        }
        return sb.ToString();
    }
    static string ConverteString(string frase)
    {
        if (EhVogal(frase[0]))
        {
            return (ConverterMaiusculas(frase));
        }
        else
        {
            return ConverterMinusculas(frase);
        }
    }
    private static void Main(string[] args)
    {
        string str;
        Console.Write("Escreva uma frase: ");
        str = Console.ReadLine();
        Console.WriteLine("\nFrase convertida: {0}",ConverteString(str));
    }
}*/

/*Questão 2: Faça um programa que leia uma matriz de números reais de tamanho 5 x 5 e, em seguida, imprima a soma dos números positivos pertencentes à diagonal secundária dessa matriz.*/
/*internal class Program
{
    const int N = 5;
    static void LerMatriz(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
    static void ImprimirMatriz(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0,4}",mat[i,j]);
            }
            Console.WriteLine();
        }
    }
    static double SomaPositivosDiagonalSec(double[,] mat)
    {
        double soma = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            if(mat[i,N-i-1]>0)
                soma+=mat[i,N-i-1];
        }
        return soma;
    }
    private static void Main(string[] args)
    {
        double[,] matriz = new double[N, N];
        Console.WriteLine("Escreva os componentes de uma matriz {0}x{0}:",N);
        LerMatriz(matriz);
        Console.WriteLine("\nMatriz: ");
        ImprimirMatriz(matriz);
        Console.WriteLine("\nSoma dos números positivos da diagonal secundária: {0}", SomaPositivosDiagonalSec(matriz));
    }
}*/
/*Questão 3: Clerysmar é o jogador mais importante da seleção brasileira de futebol. É de
conhecimento de todos que esse jogador possui um pouco de dificuldade para se manter em
pé dentro de campo. Para essa questão, vamos representar um jogo de futebol como tendo
um adversário (string), o número de pontos somados (inteiro) e o número de vezes que
Clerysmar caiu em campo (inteiro). Leia um conjunto de sete jogos e, em seguida, imprima a
média de quedas de Clerysmar e quantos jogos o número de quedas ficou abaixo da média.*/
internal class Program
{
    const int N = 7;
    static void LeJogos(Jogos[] partida)
    {
        for (int i = 0; i < partida.Length; i++)
        {
            partida[i] = new Jogos();
            Console.WriteLine("-Jogo {0}: ", i + 1);
            Console.Write("  -Adversário: ");
            partida[i].Adversario = Console.ReadLine();
            Console.Write("  -Pontos somados: ");
            partida[i].Pontos = Convert.ToInt32(Console.ReadLine());
            Console.Write("  -Quedas de Clarysmar: ");
            partida[i].Quedas = Convert.ToInt32(Console.ReadLine());

        }
    }
    static void ImpimirMediaQuedasClarysmar(Jogos[] partida)
    {
        double media = 0;
        int soma = 0, cont = 0;
        for (int i = 0; i < partida.Length; i++)
        {
            soma += partida[i].Quedas;
        }
        media = Convert.ToDouble(soma) / partida.Length;
        for (int i = 0; i < partida.Length; i++)
        {
            if (partida[i].Quedas < media)
                cont++;
        }
        Console.WriteLine("\nMédia de quedas de Clarysmar por partida: {0}", media);
        Console.WriteLine("\nClarysmar ficou abaixo de sua média em quedas em {0} partidas", cont);
    }
    private static void Main(string[] args)
    {
        Jogos[] jogo = new Jogos[N];
        Console.WriteLine("Escreva os dados dos jogos: ");
        LeJogos(jogo);
        ImpimirMediaQuedasClarysmar(jogo);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Posição: {0}", BuscaBinaria(a, 3));

    }
    static int BuscaB(int[] v, int ini, int fim, int x)
    {
        int meio = (ini + fim) / 2;
        if (v[meio] == x)
            return meio;
        if (ini == fim) return -1;
        if (v[meio] > x)
            return BuscaB(v, ini, meio - 1, x);
        else
            return BuscaB(v, meio + 1, fim, x);
    }
    static int BuscaBinaria(int[] v, int chave)
    {
        return BuscaB(v, 0, v.Length - 1, chave);
    }

}
internal class Program
{
    static void InverterMatriz(int[,] m, int[,] matinversa)
    {

        Console.WriteLine("Matriz invertida");
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                matinversa[i, j] = m[j, i];
                Console.Write("{0} ", matinversa[i, j]);
            }
            Console.WriteLine();
        }
    }
    const int N = 3;
    private static void Main(string[] args)
    {
        int[,] mat = new int[N, N];
        int[,] inverter = new int[N, N];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Matriz 1: ");
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0} ", mat[i, j]);
            }
            Console.WriteLine();
        }
        InverterMatriz(mat, inverter);
    }
}
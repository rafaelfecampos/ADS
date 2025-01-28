internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[4];

        Console.WriteLine("Escreva os elementos do vetor: ");
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Sort.Sorte(a);
    }
}
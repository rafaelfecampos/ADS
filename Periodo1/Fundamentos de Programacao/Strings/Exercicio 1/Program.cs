internal class Program
{
    private static void Main(string[] args)
    {
        string s;
        int cont=0;
        Console.Write("Escreva uma frase: ");
        s=Console.ReadLine();
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]==' ')
            {
                cont++;
            }
        }
        Console.WriteLine("\nO numero de espaço em branco na frase digitada é {0}",cont);
    }
}
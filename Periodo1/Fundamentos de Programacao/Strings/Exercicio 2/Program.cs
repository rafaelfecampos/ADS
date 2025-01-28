internal class Program
{
    static int ContarEspaco(string str)
    {
        int cont=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]==' ')
            {
                cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string s;
        int cont=0;
        Console.Write("Escreva uma frase: ");
        s=Console.ReadLine();
        Console.WriteLine("\nO numero de espaço em branco na frase digitada é {0}",ContarEspaco(s));
    }
}
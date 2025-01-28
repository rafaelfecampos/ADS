internal class Program
{
    static int ContarVogais(string s)
    {
        int cont=0;
        string vogais= "aeiouAEIOU";
        for(int i=0;i<s.Length;i++)
        {
            for(int j=0;j<vogais.Length;j++)
            {
                if(vogais[j]==s[i])
                    cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string str;
        Console.Write("Escreva uma frase: ");
        str=Console.ReadLine();
        Console.Write("Total de vogais na frase: {0}", ContarVogais(str));
    }
}
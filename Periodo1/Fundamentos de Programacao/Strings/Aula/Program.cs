/*Estrutura básica strings
internal class Program
{
    private static void Main(string[] args)
    {
        string s;
        int i;
        Console.Write("Digite uma string: ");
        s=Console.ReadLine();
        for (i=0;i<s.Length;i++)
        {
            Console.Write("{0}  ",s[i]);
        }
    }
}*/

/* Fazer uma função que retorne quantas vezes um caractere foi encontrado em uma string
internal class Program
{
    static int conta(string str, char procurado)
    {
        int cont = 0, i = 0;

        while (i < str.Length)
        {
            if (str[i] == procurado)
            {
                cont++;
            }
            i++;
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string s;
        char a;
        int i;
        Console.Write("Digite uma string: ");
        s = Console.ReadLine();
        Console.Write("Digite um caractere a ser procurado: ");
        a=Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Foi encontrado {0} vezes o caractere '{1}'.", conta(s,a),a);

    }
}*/

/*Exercicio de verificação se uma string está contida em outra
internal class Program
{
    static bool BuscarString(string str1, string str2)
    {
        int i, j, aux, tam1, tam2;
        tam1 = str1.Length;
        tam2 = str2.Length;
        for (i = 0; i < tam1; i++)
        {
            aux = i;
            for (j = 0; j < tam2 && aux < tam1; j++)
            {
                if (str2[j] != str1[aux])
                {
                    break;
                }
                aux++;
            }
            if (j == tam2) 
            return true;
        }
        return false;
    }
    private static void Main(string[] args)
    {
        string s1, s2;
        int i;
        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();
        Console.Write("Digite uma outra string: ");
        s2 = Console.ReadLine();
        if (BuscarString(s1, s2))
        {
            Console.WriteLine("\nEncontrou");
        }
        else
        {
            Console.WriteLine("Não encontrou");
        }
    }
}*/
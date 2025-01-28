/* Meu código
internal class Program
{
    static void ImprimirEst(string s)
    {
        int contC = 0, contV = 0, contO = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                if (s[i] != 'A' && s[i] != 'E' && s[i] != 'I' && s[i] != 'O' && s[i] != 'U')
                    contC++;
                else if (s[i]=='A' || s[i]=='E' || s[i]=='I' || s[i]=='O' || s[i]=='U')
                    contV++;
                else
                    contO++;
            }
            else if (s[i] >= 'a' && s[i] <= 'z')
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                    contC++;
                else if (s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
                    contV++;
                else
                    contO++;
            }
            else
                contO++;
        }
        Console.WriteLine("\nNúmero de vogais: {0}", contV);
            Console.WriteLine("\nNúmero de consoantes: {0}", contC);
            Console.WriteLine("\nNúmero de outros caracteres: {0}", contO);
    }
    private static void Main(string[] args)
    {
        string str;
        Console.Write("Escreva uma frase: ");
        str = Console.ReadLine();
        ImprimirEst(str);
    }
}*/

//Código otimizado
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
    static bool EhConsoante(char c)
    {
        if ((c >= 'B' && c <= 'Z') || (c >= 'b' && c <= 'z'))
            return true;
        else
            return false;
    }
    static void ImprimirEst(string s)
    {
        int contC = 0, contV = 0, contO = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (EhVogal(s[i]))
                contV++;
            else if (EhConsoante(s[i]))
                contC++;
            else
                contO++;
        }
        Console.WriteLine("\nNúmero de vogais: {0}", contV);
        Console.WriteLine("\nNúmero de consoantes: {0}", contC);
        Console.WriteLine("\nNúmero de outros caracteres: {0}", contO);
    }
    private static void Main(string[] args)
    {
        string str;
        Console.Write("Escreva uma frase: ");
        str = Console.ReadLine();
        ImprimirEst(str);
    }
}
/*Faça uma função que leia caracteres informados pelo usuário enquanto o caractere não for uma vogal. Assim que for lida uma vogal, a função deve retornála. Note que esta função não recebe parâmetros. No método Main, use a sua função para ler uma vogal.*/

internal class Program
{
    static char LerVogal()
    {
        char caractere;
        Console.Write("Informe uma vogal: ");
        caractere = Convert.ToChar(Console.ReadLine());

        while (caractere != 'a' && caractere != 'e' && caractere != 'i' && caractere != 'o' && caractere != 'u' &&
        caractere != 'A' && caractere != 'E' && caractere != 'I' && caractere != 'O' && caractere != 'U')
        {
            Console.WriteLine("Caractere Inválido");
            Console.Write("Informe uma vogal: ");
            caractere = Convert.ToChar(Console.ReadLine());
        }
        return caractere;
    }
    private static void Main(string[] args)
    {
        char vogal;
        vogal = LerVogal();
        Console.WriteLine("Vogal informada: {0}", vogal);
    }
}
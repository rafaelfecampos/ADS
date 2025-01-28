/*Console.Write("Informe o seu nome: ");
string? nome = null; //? indica que a variável pode ser nula

Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (nome == null)
    nome ="";
Console.WriteLine($"Nome: {nome}, idade: {idade+1}.");
Console.WriteLine($"O seu nome possui {nome.Length} letras.");*/



/*Console.Write("Informe o seu nome: ");
string? nome = Console.ReadLine() ?? ""; //?? checa se o valor atribuido é null, se for null a variável nome recebe ""

Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Nome: {nome}, idade: {idade+1}.");
Console.WriteLine($"O seu nome possui {nome.Length} letras.");*/


//REFERENCIAR
/*class Program
{
    static void Main(string[] args)
    {
        int idade = 20;

        Alterar(ref idade);

        Console.WriteLine(idade);
    }

    static void Alterar(ref int num)
    {
        num = num * 2;
    }
}*/

 
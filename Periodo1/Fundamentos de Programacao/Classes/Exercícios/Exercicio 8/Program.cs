/*Faça um programa que receba três nomes de no máximo 100 caracteres cada e as idades das respectivas pessoas em um
vetor de objetos Após o recebimento, listar os três nomes armazenados neste vetor por ordem crescente de idades*/
internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa[] pessoa = new Pessoa[3];
        for(int i = 0; i<pessoa.Length;i++)
        {
            pessoa[i]=new Pessoa();
            Console.WriteLine("Pessoa {0}",i+1);
            Console.Write("-Nome: ");
            pessoa[i].Nome = Console.ReadLine();
            Console.Write("-Idade: ");
            pessoa[i].Idade = Convert.ToInt32(Console.ReadLine());
        }
    }
}
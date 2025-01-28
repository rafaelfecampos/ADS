/*Elaborar um algoritmo para ler o código de um produto e informar a sua origem:
a) Código do produto entre 1 e 20: Europa
b) Código do produto entre 21 e 40: Ásia
c) Código do produto entre 41 e 60: América
d) Código do produto entre 61 e 80: África
e) Código do produto maior que 80: Paraguai*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Código do produto: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo >= 1 && codigo <= 20)
        {
            Console.WriteLine("Europa");
        }
        else if (codigo > 20 && codigo <= 40)
        {
            Console.WriteLine("Ásia");
        }
        else if (codigo > 40 && codigo <= 60){
            Console.WriteLine("América");
        }
        else if (codigo > 60 && codigo <= 80)
        {
            Console.WriteLine("África");
        }
        else if (codigo == 0)
        {
            Console.WriteLine("Código nao registrado");
        }
        else
        {
            Console.WriteLine("Paraguai");
        }
        Console.ReadKey();
    }
}
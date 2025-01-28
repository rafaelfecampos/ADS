internal class Program
{
    const int N = 6;
    static void MediaSalario(Pessoa[] pessoa)
    {
        double soma=0;
        int cont=0;
        for (int i = 0; i<pessoa.Length;i++)
        {
            soma+=pessoa[i].Salario;
            cont++;
        }
        Console.WriteLine("\nMédia salarial dos entrevistados: R${0:N2}",soma/cont);
    }
    static void MediaIdade(Pessoa[] pessoa)
    {
        double soma=0;
        int cont=0;
        for (int i = 0; i<pessoa.Length;i++)
        {
            soma+=pessoa[i].Idade;
            cont++;
        }
        Console.WriteLine("\nMédia de idade dos entrevistados: {0}",soma/cont);
    }
    private static void Main(string[] args)
    {
        Pessoa[] pessoa = new Pessoa[N];
        for (int i = 0; i < pessoa.Length; i++)
        {
            pessoa[i] = new Pessoa();
            Console.WriteLine("Entrevistado {0}", i + 1);
            Console.Write("-Idade: ");
            pessoa[i].Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Salário: R$");
            pessoa[i].Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        MediaIdade(pessoa);
        MediaSalario(pessoa);
    }
}
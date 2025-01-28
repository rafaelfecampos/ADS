internal class Program
{
    static int NumAlunos(int[] idade)
    {
        int soma = 0, cont = 0;
        double media = 0;
        for (int i = 0; i < 10; i++)
        {
            soma = soma + idade[i];
        }
        media = Convert.ToDouble(soma) / 10;
        for (int i = 0; i < 10; i++)
        {
            if (idade[i] > media)
                cont++;
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        int[] idade = new int[10];
        Console.WriteLine("Informe a idade dos alunos: ");
        for(int i=0;i<10;i++)
        {
            Console.Write("Aluno {0}/10: ",i+1);
            idade[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nQuantidade de alunos com idade superior a média é {0}", NumAlunos(idade));
    }
}
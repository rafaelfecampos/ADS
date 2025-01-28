/*
Considere a classe Produto abaixo e faça um procedimento que receba por parâmetro um vetor de produtos e ordene esse vetor pelo código do produto. Utilize o método da inserção para ordenar o vetor.*/
internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] prod = new Produto[4];
        Console.WriteLine("Cadastre os produtos: ");
        for (int i = 0; i < prod.Length; i++)
        {
            prod[i] = new Produto();
            Console.Write("-Código: ");
            prod[i].Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("-Descrição: ");
            prod[i].Descricao = Console.ReadLine();
            Console.Write("\n\n");
        }
        Console.WriteLine("Produtos ordenados por código: ");
        InsertSort(prod);
        for (int i = 0; i < prod.Length; i++)
        {
            Console.Write($"-Código: {prod[i].Codigo}");
            Console.Write($"-Descrição: {prod[i].Descricao}");
            Console.Write("\n\n");
        }
    }
    static void InsertSort(Produto[] vet)
    {
        for (int i = 1; i < vet.Length; i++)
        {
            int chave = vet[i].Codigo;
            string chaveS = vet[i].Descricao;
            int j = i - 1;
            while (j >= 0 && chave < vet[j].Codigo)
            {
                vet[j + 1].Codigo = vet[j].Codigo;
                vet[j + 1].Descricao = vet[j].Descricao;
                j--;
            }
            vet[j + 1].Codigo = chave;
            vet[j+1].Descricao = chaveS;
        }
    }
}
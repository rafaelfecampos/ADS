using Questao1;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaEncadeada lista = new ListaEncadeada();
        ListaEncadeada lista2 = new ListaEncadeada();

        lista.AdicionarInicio(1);
        Console.WriteLine(lista.Primeiro.Valor);

        lista.AdicionarInicio(2);
        Console.WriteLine(lista.Primeiro.Valor);

        lista.AdicionarFinal(3);

        Imprimir(lista);

        lista.RemoverInicio();
        Imprimir(lista);

        lista.RemoverFinal();
        Console.WriteLine("\nLista 1 ");
        Imprimir(lista);

        lista2.AdicionarInicio(2);
        lista2.AdicionarFinal(3);
        Console.WriteLine("\nLista 2 ");
        Imprimir(lista2);

        Console.WriteLine("\nLista 1 ");
        lista.AdicionarVariosNoInicio(lista2);
        Imprimir(lista);
    }

    private static void Imprimir(ListaEncadeada lista)
    {
        No aux = lista.Primeiro;

        Console.Write("Lista: ");

        while (aux != null)
        {
            Console.Write("{0,3}", aux.Valor);
            aux = aux.Proximo;
        }

        Console.WriteLine();
    }
}
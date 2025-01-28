using Revisao;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaDupla lista = new ListaDupla();
        
        lista.AdicionarNoInicio(1);
        lista.AdicionarNoInicio(0);
        lista.AdicionarNoInicio(-1);
        lista.AdicionarNoFinal(2);
        lista.AdicionarNoFinal(3);

        imprimir(lista);

        lista.RemoverNoInicio();
        lista.RemoverNoFinal();

        imprimir(lista);

        Console.Write("Valor do elemento anterior ao elemento de valor 1: ");
        Console.WriteLine((lista.Localizar(1).Anterior!=null)?lista.Localizar(1).Anterior.Valor:"###Erro: Elemento nulo!!!###");

    }
    public static void imprimir(ListaDupla lista){
        No aux = lista.Primeiro;
        Console.Write("Lista: ");
        while(aux!=lista.Ultimo.Proximo){
            Console.Write("{0,3}", aux.Valor);
            aux = aux.Proximo;
        }
        Console.WriteLine();
    }
}
﻿using Simulado2;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaEncadeada lista = new ListaEncadeada();
        Console.Write("Informe um numero inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n != 0)
        {
            if (n % 2 == 0)
            {
                lista.AdicionarNoInicio(n);
            }
            else
            {
                lista.AdicionarNoFinal(n);
            }
            Console.Write("Informe um numero inteiro (insira 0 para terminar): ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Imprimir(lista);
        while (lista.Primeiro!=null)
        {
            lista.RemoverNoFinal();
        }
        Imprimir(lista);
    }
    public static void Imprimir(ListaEncadeada lista)
    {
        if (lista.Primeiro == null)
        {
            Console.WriteLine("Lista vazia!");
        }
        else
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
}
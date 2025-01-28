class Program
{
    static void Main(string[] args)
    {
        //Imprime(5);

        //ImprimeSomaDe1Ate(3);

        Console.WriteLine($"Soma de 1 até 3: {SomaDe1Ate(3)}.");
    }

    static int SomaDe1Ate(int numero)
    {
        if (numero <= 0)
        {
            return 0;
        }

        return numero + SomaDe1Ate(numero - 1);
    }

    /*
    static void ImprimeSomaDe1Ate(int numero, int soma = 0)
    {
        if (numero <= 0)
        {
            Console.WriteLine($"Soma: {soma}.");
            return;
        }

        ImprimeSomaDe1Ate(numero - 1, soma + numero);
    }
    */

    /*
    static void Imprime(int numero)
    {
        if (numero <= 0)
            return;

        Imprime(numero - 1);

        Console.WriteLine(numero);
    }
    */
}
﻿
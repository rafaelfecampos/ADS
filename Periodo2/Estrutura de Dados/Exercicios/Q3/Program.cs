﻿/*Questão 3: Faça um procedimento que receba o montante reservado para a
aposentadoria de uma pessoa e a quantia que ela pretende retirar por mês. O
montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após
a retirada. O procedimento deve imprimir o montante (após a retirada e a correção),
mês a mês. O procedimento também deve imprimir o número de meses em que a
pessoa conseguirá fazer a sua retirada. Restrição: não utilize comandos de
repetição*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe o montante reservado para a aponsentadoria: R$");
        double montante = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a quantia de retirada mensal: R$");
        double retirada = Convert.ToDouble(Console.ReadLine());
        Aposentadoria(montante, retirada);
    }
    static void Aposentadoria(double montante, double retirada, int cont = 0, int i = 1)
    {
        if (montante > retirada)
        {
            Console.WriteLine($"Retirada {i}:");
            montante -= retirada;
            montante += montante * 0.0055;
            Console.WriteLine("-Montante restante: R${0:N2}\n",montante);
            Aposentadoria(montante, retirada, cont + 1, i + 1);
        }
        else
            Console.WriteLine($"Em {cont} meses serão possíveis realizar a retirada!");
    }
}
/*Faça um programa que lê um valor de salário mínimo e o salário de um funcionário. O programa deve calcular e imprimir quantos salários mínimos esse funcionário ganha.*/
internal class Program
{
    private static void Main(string[] args)
    {
        double salario_minimo, salario_funcionario, numeros_sal_min;

        salario_minimo = 1302.00;
        Console.Write("Informe o salário do funcionário: R$");
        salario_funcionario = Convert.ToDouble(Console.ReadLine());
        numeros_sal_min = salario_funcionario/salario_minimo;

        Console.Write("O funcionário recebe {0} salário(s) mínimo(s)", numeros_sal_min);
        }
}
/*Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: se idade < 13: Criança, se 13 ≤ idade < 20: Adolescente, se 20 ≤ idade < 60: Adulto e se idade ≥ 60: Idoso.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade < 13){
            Console.WriteLine("Criança");
        }
        else if (idade >= 13 && idade <20){
            Console.WriteLine("Adolescente");
        }
        else if (idade >= 20 && idade <60){
            Console.WriteLine("Adulto");
        }
        else{
            Console.WriteLine("Idoso");
        }
        Console.ReadKey();
    }
}
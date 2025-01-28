/*
Questão 1: Faça um procedimento que receba um número n inteiro e positivo. O
procedimento deve imprimir todos os números do intervalo entre 0 e n que são
divisíveis por 2 e por 3 (simultaneamente). Restrição: não utilize comandos de
repetição
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro e positivo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Intervalo(n);
    }
    static void Intervalo(int n){
        if(n>0){
            Console.WriteLine($"Número divisiveis simultaneamente por 2 e 3 no intervalo entre 0 e {n}:");
            Intervalo(n, 0);
        }
        else{
            Console.WriteLine("Número negativo\nAção inválida!");
        }
    }
    static void Intervalo(int n, int i){
        if(i<=n){
                if(i%2 == 0 && i%3==0 ){
                    Console.WriteLine(i);
                }
                Intervalo(n, i+1);
            }
    }
}
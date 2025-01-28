using System;

class Program
{
    //@@@Questão 1
    //Faça uma função que leia números inteiros informados pelo usuário enquanto não for 
    //lido um número positivo. Assim que for lido um número positivo, a função deve
    //retornar este número. Observação: esta função não recebe parâmetros.
    static int LerInteiro()
    {
        int n;
        Console.Write("Informe um número inteiro positivo: ");
        n = Convert.ToInt32(Console.ReadLine());

        while (n <= 0)
        {
            Console.WriteLine("Número inválido!");
            Console.Write("Informe um número inteiro positivo: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        return n;
    }

    static void Main(string[] args)
    {
        //@@@Questão 2:
        //Leia a variável qtdeNumeros. Para isso, apresente ao usuário a mensagem 
        //"Informe a quantidade de números positivos a serem lidos: " e, assim que informado, 
        //se qtdeNumeros for zero ou negativo, apresente a mensagem "Quantidade de números 
        //inválida!". Caso contrário, execute o código da questão 3.
        int qtdeNumeros;
        Console.Write("Informe a quantidade de números positivos a serem lidos: ");
        qtdeNumeros = Convert.ToInt32(Console.ReadLine());
        if (qtdeNumeros <= 0)
        {
            Console.WriteLine("\nQuantidade de números inválida!\n");
        }
        //@@@Questão 3:
        //Nesta questão chamaremos de N o valor armazenado na variável qtdeNumeros.
        //Para esta questão, leia N números positivos informados pelo usuário. Ao término,
        //da leitura, informe qual o maior número lido. Observação: note que precisamos 
        //ler números positivos e que você deve fazer as N leituras chamando a função criada 
        //na questão 1 para garantir que o número lido é positivo.
        else
        {
            int i, num, maior = 0;
            for (i = 0; i < qtdeNumeros; i++)
            {
                num = LerInteiro();
                if (num > maior)
                {
                    maior = num;
                }
                Console.WriteLine("\nInteiro positvo {0} de {1} lido.\n", i + 1, qtdeNumeros);
            }
            Console.WriteLine("O maior numero inteiro e positivo lido é {0}.\n", maior);
        }
    }
}
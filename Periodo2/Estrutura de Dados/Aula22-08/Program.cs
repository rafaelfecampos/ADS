// int inicio = 1, fim = 5;

// Console.WriteLine($"Soma dos pares entre {inicio} e {fim}: {SomaPares(inicio, fim)}.");

// // int SomaPares(int primeiro, int ultimo)
// // {
// //     int soma = 0;

// //     for (int num = primeiro; num <= ultimo; num++)
// //         if (num % 2 == 0)
// //             soma += num;
    
// //     return soma;
// // }

// int SomaPares(int num, int ultimo)
// {
//     if(num<=ultimo)
//     {
//         if(num%2==0)
//             return num + SomaPares(num+2,ultimo);
//         else
//             return SomaPares(num+1, ultimo);
//     }
//     else
//         return 0;
// }

int inicio = 1, fim = 10;


Console.WriteLine($"Soma dos números entre {inicio} e {fim}: {SomaIntervalo(inicio, fim)}.");

int SomaIntervalo(int primeiro, int ultimo)
{
    // if(primeiro<=ultimo)
    // {
    //     return primeiro + SomaIntervalo(primeiro+1, ultimo);
    // }
    // else 
    //     return 0;

    return primeiro<=ultimo? primeiro + SomaIntervalo(primeiro+1, ultimo):0;
}

//##ESCOPO DE FUNÇÃO##
/*'use strict' //define imposições ao escrever o código, ex: variável precisa ter o tipo declarado
const PI = 3.14;
var valor1 = 132;
let valor2 = 456;
valor3 = 789;

console.log(PI, valor1, valor2, valor);*/

//Escopo de bloco

/*var aprovado = true;//var não respeita o escopo de bloco!!!!!!!!!!!!
 if(aprovado){
    var texto = "Aprovado";
    
 }
 console.log(texto);*/

 /*var aprovado = true;//let respeita o escopo de bloco!!!!!!!!!!!!
 if(aprovado){
    let texto = "Aprovado";
    
 }
 console.log(texto);*/
 //const e let preservam o escopo

 /*let aprovado = true;
 let frequencia = 0.8;

 if(aprovado){
    if(frequencia>0.7){//frequencia declarada no escopo pai
        let texto = "Aprovado";
        console.log("Dentro do if", texto);
    }
 }*/


 //exercicios: ex3
 var numero = 50;

for(var numero = 0; numero < 10; numero++) {
    console.log(numero);
}

const total = 10 * numero;
console.log(total);
//o segundo var numero sobrescreve o primeiro
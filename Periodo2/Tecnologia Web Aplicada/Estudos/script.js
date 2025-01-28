//topico 1
//##### DECLARAÇÃO DE VARIÁVEIS
let nome = 'Rafael';
let idade = 22;
let comidaFav = 'PF';
let lul, johnson, desq;

console.log(nome);
console.log(idade);
console.log(comidaFav);
console.log(lul);
console.log(johnson);
console.log(desq);

//topico 2
//##### CONDICIONAL
let time = 'Botafogo de Futebol e Regatas';
let numStr = '22';
let age = 22;
let frase = `Meu nome é ${nome} e minha idade é ${age}`;
let surname = 'Campos';
console.log(`${nome} ${surname}`);
let frase2 = 'It\'s study time';
console.log(frase2);
console.log(typeof nome);

let idadePai = 62;
if (idade > idadePai)
    console.log('É maior');
else if (idade == idadePai)
    console.log('É igual');
else
    console.log("É menor");
/*3*/
var expressão = (5 - 2) && (5 - ' ') && (5 - 2);
console.log(expressão);
var nome2 = 'João';
var idade2 = 28;
var possuiDoutorado = false;
var empregoFuturo;
var dinheiroNaConta = 0;
if (dinheiroNaConta)
    console.log('true');
else
    console.log('false');

var brasil = 207, china = 1340;
console.log((brasil > china) ? "Brasil mais população" : "China mais população");
if (('Gato' === 'gato') && (5 > 2)) {
    console.log('Verdadeiro');
} else {
    console.log('Falso');
}//falso
if (('Gato' === 'gato') || (5 > 2)) {
    console.log('Gato' && 'Cão');
} else {
    console.log('Falso');
}//Cão
// && retorna o ultimo valor true que encontrar e || retorna o primeiro valor true que encontrar

var scroll = 1000;
scroll += 5;
console.log(scroll);
var darCredito
var possuiCarro = true;
var possuiCasa = true;

darCredito = (possuiCarro && possuiCasa) ? true : false;
console.log(darCredito);

//topico 3
//####### FUNCTION
function ehTrue(valor) {
    (valor) ? console.log('É true') : console.log('É false');;
}
ehTrue('gato' === 'Gato');

function perimetroQuad(lado) {
    return lado * 4;
}
console.log(perimetroQuad(5));

function nomeCompleto(nome, sobrenome) {
    return nome + ' ' + sobrenome;
}
console.log(nome, surname);

function ehPar(numero) {
    return (numero % 2 == 0) ? true : false;
}
(ehPar(7)) ? console.log('É par') : console.log('É ímpar');

function tipoDado(dado) {
    return typeof dado;
}
console.log(tipoDado('Ronaldo'));

// addEventListener('scroll', function(){
//     console.log(nomeCompleto(nome,surname));
// })


//##### EXERCICIO ELEFANTE USANDO OBJETO E ARRAY
var elefante = {
    quantidade: 10,
    imprimirLetra() {
        let letra = '';
        let incomodam = [];
        for (let i = 1; i <= this.quantidade; i += 2) {
            letra += (i == 1) ? `${i} elefante incomoda muita gente` : `${i} elefantes incomodam muita gente`;
            letra += `\n${i + 1} elefantes`;
            for (let j = 1; j <= 2; j++) {
                incomodam.push(` incomodam`)
            }
            letra += incomodam;
            letra += ` muito mais\n\n`;
        }
        for (let i = 10; i >= 1; i -= 2) {
            letra += `${i} elefantes incomodam muita gente\n`;
            letra += `${i - 1} elefantes`;
            incomodam.pop();
            letra += (incomodam.length != 1) ? incomodam : ` incomoda`;
            incomodam.pop();
            letra += ` muito menos\n\n`;
        }
        console.log(letra);
    }
}
console.log(elefante.imprimirLetra());
console.log(elefante);

//##### ARROW FUNCTION ####
//fuction normal
// function imc(peso, altura) {
//     return peso / (altura ** 2);
// }
//arrow function
var imc = (peso, altura) => {
    return peso / (altura ** 2);
}
console.log(imc(80, 1.83));

//topico 4
//#### FOR EACH 
var videoGames = ['Switch', 'PS5', 'XBox', '3DS'];
var lista = []  
videoGames.forEach(function(item) {
    lista.push(item)
});
console.log(lista); //imprime os elementos do array lista

//#### VAR X LET
// if(true) {
//     var carro = 'Fusca';
//     console.log(carro);
// }
// console.log(carro); //com var a variavel é acessada fora do bloco

if(true) {
    let carro = 'Fusca';
    console.log(carro);
}
//console.log(carro); //com let a variavel nao pode ser acessada fora do bloco


  
  
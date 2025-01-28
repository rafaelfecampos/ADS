/*var nome = "Juquinha";
let sobrenome = "Silva"
const idade = 30;
//constante não se pode fazer outra atruibuição, gasta menos memória
nome = "Juca";
sobrenome = "Silva Pereira";
idade = 31;*/

//-----------------------

/*
//var nome;

//nome="Maria";
nome="Maria"; //se nao tiver no modo estrito do js, não tem necessidade ce declarar a variável, mas não é recomendado
console.log(nome);*/

//-----------------------

/*
var nome = "Maria";
const idade = 31; //precisa atribuir algum valor à uma constante ao declará-la*/

//-----------------------

/*
var nome = "Maria",
    Nome = "João"
    sobrenome = "Silva",
    idade = 27;
console.log(nome);
console.log(Nome);
console.log(sobrenome);
console.log(idade);*/

//-----------------------

/*
//hoisting
nomeCompleto = "João Silva";
console.log(nomeCompleto);
var nomeCompleto = "Maria Silva";
console.log(nomeCompleto);

teste= false;
console.log(teste);
var teste = true;*/

//-----------------------

/*
var nome = "Rafael";
console.log(typeof nome); //tipo da variável é string
nome = 465;
console.log(typeof nome); //tipo da variável é number*/

//-----------------------

//Concatenação de string
/*var nome = 'Rafael';
var sobrenome = 'Ferreira Campos';
var idade = 22;
var nomeCompleto = nome + ' ' + sobrenome;
console.log(nomeCompleto);
var frase = 'idade: ' + idade;
console.log(frase);
console.log(typeof frase);



var var1 = 123;
var var2 = '4';
var total = var1 + var2;
console.log('Total: ', total);
console.log('Tipo total:', typeof total);*/

//-----------------------

//Pode-se utilizar aspas duplas e aspas simples para a mesma funcionalidade no js puro
/*var texto1 = 'javascript é "super" fácil';
var texto2 = "javascript é 'super fácil";
var texto3 = "javascript é \"super\" fácil";
var texto4 = 'javascript é 'super' fácil';*/ //errado

//-----------------------

/*var aluno = "Juca";
var nota = 10;
var texto = `A nota do ${aluno} foi ${nota}`;
var texto1 = "A nota do \n" + aluno + " foi + nota; //para quebrar linha com concatenação normal necessita utilizar \n
console.log(texto);
console.log(texto1);*/

//-----------------------

//EXERCICIO
/*var nome = "Rafael";
var stringnum = "2023";
var idade = 22;
var texto = `Meu nome é Rafael e minha idade é 22`;
var sobrenome = "Campos";
var nomeCompĺeto = `${nome} ${sobrenome}`;
var frase = 'It\'s study time!';
console.log(nome);
console.log(stringnum);
console.log(idade);
console.log(texto);
console.log(sobrenome);
console.log(nomeCompĺeto);
console.log(frase);
console.log(typeof nome);*/

//-----------------------

//Representação numerica
/*var numero = 2.13e2; //exponecial 2,13*10^2
var numero2 = 2.12e-3; //exponencial 2,12*10^-3
console.log("n1: ", numero);
console.log("n2: ", numero2);*/

//-----------------------

//Operações
/*var numero = 2 ** 4; //2**4 = 2⁴ = 16
console.log("2 ** 4 = ", numero);*/

//-----------------------

//Operadores em string
/*var numero1 = 'comprei 100';
var numero2 = 2;
console.log(numero1 - numero2);//converão automática de string para number, funciona para a multiplicação e divisão também.
//Sinal de adição apenas concatena
//Se tiver mais algum elemento além de numero na string gera um NaN*/

//-----------------------

//pós e pré-incremento
/*var numero = 10;
console.log(numero++); //pós-incremento, incrementa o valor após do comando
console.log(numero);

var numero2 = 10;
console.log(--numero2); //pré-incremento, incrementa o valor antes do comando*/
//exemplo
/*var numero1 = 10;
var numero2 = numero1++;
console.log("n1:",numero1," n2:",numero2);
var n1 = 10;
var n2 = --n1;
console.log("n1:", n1, "n2:", n2);*/

//-----------------------

//+ e - como conversor de tipo e de sinal

/*var texto = "10";
var numero = +texto;*/ //converte o tipo de variável
/*var texto = "10";
var numero = -texto; //converte o tipo de variável e o sinal

console.log(typeof numero, numero);*/

//-----------------------

//CONDICIONAL
//switch
/*var cor = 4;

switch (cor){
    case 1:
        console.log("A cor é Preto");
        break;
    case 2:
        console.log("A cor é amarelo");
        break;
    case 3:
        console.log("A cor é Azul");
        break;
    case 4:
        console.log("A cor é Verde");
        break;
    default:
            console.log("Nenhum cor válida");
}*/

//-----------------------

//if
//valores considerados false
//var cor = ''; //'' = false
/*var cor = "botafogo";//string com alguma frase ou ' ' = true
if (cor) {
    console.log("tem cor");
}
else {
    console.log("não tem cor");
}*/

//-----------------------

//OPERADOR NEGAÇÃO
/*var cor = 0;

if (!cor){
    console.log("não tem cor");
}
else{
    console.log("tem cor");
}*/

//---------------------------

//COMPARAÇÃO IGUALDADE E ESTRITA
/*var a = 10;
var b = "10";
if(a === b){ //verifica além do valor da varíavel, mas como também verifica o tipo da variável
    console.log("São iguais");
}
else{
    console.log("São diferentes");
}*/

//-----------------------

//OPERADORES LÓGICOS
//&&, para de verificar ao encontrar false
/*var b;
var a = 0;
var c = 1;

if (a || c){
    console.log("true");
}else{
    console.log("false");
}

(a == 0) && console.log('BOTAFOGO');

var resultado = "cão" && "gato" && true;

console.log(resultado);*/

//||, para de verificar ao encontrar true
/*var a ;
var b = 10;
var c = false;

a || b || c || console.log("Final");*/

//-----------------------

//EXERCICIO PT2
if (('Gato' == 'gato') || (5 > 2)) {
    console.log("Gato" && "Cão");
} else {
    console.log("Falso");
}
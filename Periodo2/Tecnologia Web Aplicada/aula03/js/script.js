/*function
imprimeAreaQuadrado(4);
imprimeAreaQuadrado(5);
imprimeAreaQuadrado(22);
imprimeAreaRetangulo(3,4);
console.log(areaQuadrado(4));
console.log(areaQuadrado(5));
console.log(areaQuadrado(22));*/

/*function areaQuadrado(lado){
    return lado*lado;
}
function imprimeAreaQuadrado(lado){
    console.log(lado*lado);
}
function imprimeAreaRetangulo(base, altura){
    var area = base*altura;
    console.log(`A área de um retângulo ${base}x${altura} é: ${area}`);
}

var areaQuadrado2 = areaQuadrado;
console.log(areaQuadrado2(3));*/

//addEventListener/ Funções de
/*addEventListener('click', function(){
    console.log('Clicou');
})*/
/*function imprimeClique() {
    console.log('Clicou');
};
addEventListener('click', imprimeClique);

var imprimeClique = function(){
    console.log("Clicou");
}
addEventListener('click', imprimeClique);

var cont = 0;
addEventListener('click',function(){
    console.log(`Clicou ${++cont}`)})*/


// funções anonimas
/*function imc(peso, altura){
    const imc = peso / (altura**2);
    return imc;
}
var resultado = imc(80,18.0);
console.log(resultado); //quando a função nao tem retorno ela retorna undefined*/

/*function teste(parametro){
    console.log(parametro);
}
var teste2 = function (params){
    console.log(params);
}

var teste3 = (params) => {  //arrow function
    console.log(params);
}
teste(1);
teste2(2);
teste3(3);*/
//Exemplo: passando a função abaixo para arrow function
/*function imc(peso, altura) {
    const imc = peso / (altura**2);
}*/
/*var imc = (peso, altura) => {
    return peso/(altura**2);
}

imc(80, 1.80);
console.log(imc(80,1.83));*/

//Escopo

/*var totalExercicio = 10;

function exerciciosResolvidos(resolvidos){ //a funcão consegue utilizar parametros declados fora da função, mas o main nao consegue utilizar parametros declarados na função
    return `Ainda faltam ${totalExercicio - resolvidos} exercícios para resolver`;
}
console.log(exerciciosResolvidos(6));*/

/*var nota = 10;
var media = 7;
var frequenciaMin = 0.75;
function aprovado(nota, frequencia){
    if(nota>=media){
        if (frequencia >= frequenciaMin){
        return true;}
    }else{
        return false;
    }
}
console.log(aprovado(7,0.8));*/

//Escopo léxico
/*var profissao = 'Desenvolvedor';

function dados() {  
    var nome = 'Joãozinho';  
    var idade = 28;
    function outrosDados() {
        var endereco = 'Rio de Janeiro';
        var idade = 29;
        return `${nome}, ${idade}, ${endereco}, ${profissao}`;
    }
    return outrosDados();
}

console.log(dados()); // Retorna 'Joãozinho, 29, Rio de Janeiro, Desenvolvedor'
//outrosDados(); // retorna um erro*/

//Hosting
/*imc(80, 1.80); // imc aparece no console  
function imc(peso, altura) {
    const imc = peso / (altura ** 2);  
    console.log(imc);
}*/

//EXERCICIOS

//1
function ehTrue(valor){
    if(valor)
        return true;
    else
        return false;
}
var val = ' ';
console.log(ehTrue(val));

//2
var Perimetro = (lado) =>{
    return lado*4;
}
var lados = 5;
console.log(Perimetro(lados));

//3
var nomeCompleto = (nome, sobrenome) =>{
    return nome + ' ' + sobrenome;
}
var nome = 'Rafael';
var sobrenome = 'Ferreira Campos';
console.log(nomeCompleto(nome, sobrenome));

//6
addEventListener('scroll', ()=>{
    console.log(nomeCompleto(nome, sobrenome));
})
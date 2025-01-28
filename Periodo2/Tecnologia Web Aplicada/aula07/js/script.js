// let paragrafo1 = document.getElementsByClassName('impar'); //selecionar um unico elemento: getElementByID

// // let arrayPar1 = Array.from(paragrafo1);

// let paragrafo2 = document.querySelectorAll('.impar'); //selecionar uma classe ou elementos mais complexos

// console.log(paragrafo1);
// console.log(paragrafo2);


//##alterar, adicionar e remover classes, ids no html
// let paragrafo = document.querySelector('p');
// console.log(paragrafo.className);
const corpo = document.querySelector('body');
const linha = document.getElementById("modoEscuro");

function modoEscuro() {

    if (corpo.classList.contains('escuro')) {
        corpo.classList.remove('escuro')
        linha.innerText = "Modo Escuro";
    }
    else {
        corpo.classList.add('escuro');
        linha.innerText = "Modo Claro";
    }
}

function alterarModo() {
    const textosAzul = document.querySelectorAll(".texto-azul");

    if (textosAzul.length > 0) {
        textosAzul.forEach(texto => {
            texto.classList.replace('texto-azul', 'texto-vermelho')
        });
    } else {
        const textosVermelho = document.querySelectorAll('.texto-vermelho')
        if (textosVermelho.length > 0) {
            textosVermelho.forEach(texto => {
                texto.classList.replace('texto-vermelho', 'texto-azul')
            });
        }
    }



    //corpo.classList.toggle('escuro'); //toggle simplifica a função acima, se tiver a classe x, remove x; se nao tiver a classe x, adiciona x
    
}

// 19/09

// const link = document.getElementById('LinkGoogle');
// console.log(link.getAttribute('src'));
// console.log(link.attributes);

const link = document.getElementById('LinkGoogle');
link.setAttribute('nomeAtributo', 'novoAtributo');
array.forEach(element => {
    
});

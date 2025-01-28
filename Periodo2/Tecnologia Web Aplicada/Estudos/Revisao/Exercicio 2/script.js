const butao = document.getElementById("click-me");
const contador = document.getElementById("counter");
let cont = 0;

butao.addEventListener('click', event=>{
    cont+=100;
    contador.innerText = cont;
})
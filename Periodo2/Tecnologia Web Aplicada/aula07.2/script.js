let images = ['./assets/images/1.png', './assets/images/2.jpg', './assets/images/3.jpeg', './assets/images/4.jpeg'];

let atual = 0;
const slide = document.getElementById('slide');
slide.setAttribute('src', images[atual]);

//funções para avançar e voltar as imagens
function avancar() {
    atual++;
    if (atual == images.length) { atual = 0; }
    slide.setAttribute('src', images[atual]);
}
function voltar() {
    atual--;
    if (atual == -1) { atual = images.length-1; }
    slide.setAttribute('src', images[atual]);
}


//BOTOES PARA AVANÇAR OU VOLTAR AS IMAGENS
const btnAvancar = document.getElementById('btnAvancar');
const btnVoltar = document.getElementById('btnVoltar');

//CLICA NA IMAGEM AVANÇA, DOIS CLIQUES VOLTA
btnAvancar.addEventListener('click', avancar );
btnVoltar.addEventListener('dblclick', voltar );

// const linkAvancar = document.getElementById('linkAvancar');
// const linkVoltar = document.getElementById('linkVoltar');

// linkAvancar.addEventListener('click', (event)=>{
//     event.preventDefault();
//     atual++;
//     if (atual == images.length) { atual = 0; }
//     slide.setAttribute('src', images[atual]);
// });
// linkVoltar.addEventListener('click', (event) =>{
//     event.preventDefault();
//     atual--;
//     if (atual == -1) { atual = images.length-1; }
//     slide.setAttribute('src', images[atual]);
// });


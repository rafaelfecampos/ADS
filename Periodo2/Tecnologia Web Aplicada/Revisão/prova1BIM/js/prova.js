/* 
Questão 01- Modo noturno 

Aplique o modo noturno na página apresentada:

    • Utilize JavaScript para selecionar o link "Modo Noturno", o body e os botões de Anterior e Próximo.
    • Adicione um event listener ao link "Modo Noturno" que detecte o evento de clique do mouse.
    • Quando o link for clicado, ative a classe dark ao body e troque a classe is-dark para is-light nos botões. 
    • Quando o link for clicado novamente as alterações devem ser desfeitas.
    • Atualize o texto do link para "Modo Diurno" quando o modo noturno estiver ativo e vice-versa.
*/
let darkMode = document.getElementById('toggleNightMode');
let body = document.querySelector('body');


darkMode.addEventListener('click', (event)=>{
    body.classList.toggle('dark');
    if(darkMode.innerText== "Modo Noturno"){
        darkMode.innerText="Modo Diurno";
    }
    else{
        darkMode.innerText="Modo Noturno";
    }
})

/*
Questão 02- Galeria de Imagens

Crie um script que apresente uma galeria de imagens:

    • Adicione um array no JavaScript contendo URLs de todas as imagens presentes na pasta “./images/bagmon/”
    • Utilize JavaScript para selecionar a área de visualização de imagem e os botões "Anterior" e "Próximo".
    • Defina a primeira imagem do array como a imagem inicial na área de visualização.
    • Adicione event listeners aos botões "Anterior" e "Próximo" que detectem o evento de clique do mouse.
    • Quando o botão "Anterior" for clicado, exiba a imagem anterior do array na área de visualização. Se a imagem atual for a primeira, exiba a última imagem do array.
    • Quando o botão "Próximo" for clicado, exiba a próxima imagem do array na área de visualização. Se a imagem atual for a última, exiba a primeira imagem do array.

*/
let images = ["./images/bagmon/1.jpeg","./images/bagmon/2.jpeg","./images/bagmon/3.jpeg","./images/bagmon/4.jpeg","./images/bagmon/5.jpeg","./images/bagmon/6.jpeg","./images/bagmon/7.jpeg","./images/bagmon/8.jpeg","./images/bagmon/9.jpeg","./images/bagmon/10.jpeg"];

let proximo = document.getElementById('nextButton');
let anterior = document.getElementById(('prevButton'));;
let img = document.querySelector('.image img');
let atual=0;

proximo.addEventListener('click', event=>{
    event.preventDefault();
    atual++;
    if(atual > images.length-1)
        atual=0;
    img.src = images[atual];

})
anterior.addEventListener('click', event=>{
    event.preventDefault();
    atual--;
    if(atual < 1)
        atual=9;
    img.src = images[atual];
})
/*
Questão 03 - Extra

Crie um script para mostrar no campo texto alternativo (alt) da imagem o nome do respectivo Bágmon.

*/
let nome = ["Voara", "Azurara", "Ararazul", "Pequemico", "Micorado", "Douraleão", "Capi", "Varacapi", "Capilorde", "Tamanduí"];

proximo.addEventListener('click', event=>{
    event.preventDefault();
    if(atual > images.length-1)
        atual=0;
    img.alt = nome[atual];
})
anterior.addEventListener('click', event=>{
    event.preventDefault();
    if(atual < 1)
        atual=9;
    img.alt = nome[atual];
})
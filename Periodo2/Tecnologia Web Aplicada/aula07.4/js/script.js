// const link1 = document.querySelector('li');

// console.log(link1.innerHTML);

// link1.innerHTML = '<button> Clique </button>';


// let links = document.querySelectorAll('nav a');

// links.forEach(link => {
//     link.addEventListener('click', event =>{
//         event.preventDefault();
//         document.body.innerHTML+='<p> Clicou </p>';
//     })
// });

const menu = document.querySelector('ul');

const paragrafo = menu.querySelector("nav p");

const conteudo = document.getElementById('conteudo');

const primeiroli = document.querySelector("nav ul li");

const ultimoParagrafo = document.createElement('p');
ultimoParagrafo.innerText ="Ultimo texto";
conteudo.appendChild(ultimoParagrafo);

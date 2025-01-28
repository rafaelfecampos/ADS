let submit = document.getElementById('enviar');
let lista = document.querySelector('ul');
let item = document.getElementById('item');

submit.addEventListener('click', event=>{
    event.preventDefault();
    let elemento = document.createElement('li');
    elemento.textContent=item.value;
    lista.appendChild(elemento);
})

let excluir = document.getElementById('excluir');

excluir.addEventListener('click', event=>{
    event.preventDefault();
    let elemento = lista.children[--lista.children.length];
    lista.removeChild(elemento);
})
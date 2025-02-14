const numero = Math.floor(Math.random()*100+1);

const usuario = document.getElementById("usuario");
const idForm = document.getElementById("id");
const titulo = document.getElementById("titulo");
const corpo = document.getElementById("corpo");


fetch(`https://jsonplaceholder.typicode.com/posts/${numero}`)
    .then((response) => response.json())
    .then(
    (json) => {
        usuario.value = json.userId;
        idForm.value= json.id;
        titulo.value= json.title;
        corpo.value= json.body;
    }    
    );

document.getElementById("botao").addEventListener("click", (event) =>{
    event.preventDefault();
    
    const update ={
        method: 'PUT',
        headers:{
            'Content-type': 'application/json; charset=UTF-8',
        },
        body: JSON.stringify({
            id: parseInt(idForm.value,10),
            title: titulo.value,
            body: corpo.value,
            userId: usuario.value
        })
    }
    fetch(`https://jsonplaceholder.typicode.com/posts/${numero}`,update)
        .then((response) => response.json())
        .then((json) => console.log(json));
});
    















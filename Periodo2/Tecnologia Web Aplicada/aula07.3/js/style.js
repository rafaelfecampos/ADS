const nome = document.getElementById('name');
const senha = document.getElementById('senha');
const cadastro = document.getElementById('cadastro');

cadastro.addEventListener('submit', event => {
    console.log(event);
    event.preventDefault();
    const psw = senha.value;
    if (psw.length < 6) {
        alert(`${nome.value}, a senha deve ter 6 digitos!`);
    } else {
        cadastro.submit();
    }
    // console.log(nome.value, senha.value);
})

const testes = document.querySelectorAll('.teste');

// teste.addEventListener('click', event => {
//     event.preventDefault();
//     teste.innerText = 'Clicou!';
// })

testes.forEach(teste => {
    teste.addEventListener('click', event => {
        event.preventDefault();
        teste.innerText = 'Clicou!';
    });
});

window.addEventListener('keydown', event => {
    if (event.key == 'a') {
        document.body.classList.toggle('modoEscuro')
    }
})
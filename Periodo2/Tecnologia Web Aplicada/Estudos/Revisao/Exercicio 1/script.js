const botao = document.querySelector("button");
const tarefa = document.getElementById("new-task");
const lista = document.getElementById("task-list");

botao.addEventListener("click", event=>{
    const tarefaNova = document.createElement("li");
    tarefaNova.className= 'task';
    tarefaNova.innerText = tarefa.value;
    lista.appendChild(tarefaNova);
    tarefa.value = '';
})
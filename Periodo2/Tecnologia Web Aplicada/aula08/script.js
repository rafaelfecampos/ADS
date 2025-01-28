// function Aluno (nome, matricula){
//     this.nome = nome
//     this.matricula = matricula;
// }

// const juquinha = new Aluno("Juquinha","123456");
// const zezinho = Object.create(juquinha);

// zezinho.nome = "zezinho";

// console.log(juquinha.constructor);
// console.log(zezinho.constructor);

// function Aluno(nome, matricula){
//     this.nome=nome;
//     this.matricula = matricula;
// }

// Aluno.prototype.digaOi = function (){
//     console.log(`Ola eu sou o(a) ${this.nome}`);
// }

// const zezinho = new Aluno("Zezinho", "123456");

// zezinho.digaOi();

// class Aluno {
//     constructor(nome, matricula) {
//         this.nome = nome;
//         this._matricula = matricula;
//     }

//     get matricula(){
//         return this._matricula;
//     }
//     set matricula(value){
//         this._matricula=value;
//     }

//     digaOi(){
//         console.log(`Olá  eu sou o(a) ${this.nome}`);
//     }
// }

// class Bolsista extends Aluno{
//     #projeto;
//     constructor(nome, matricula, projeto) {
//         super(nome, matricula);
//         this.#projeto = projeto;
//     }
//     imprimeProjeto(){
//         console.log(`Projeto: ${this.#projeto}`);
//     }

//     get projeto(){
//         return `Projeto: ${this.#projeto}`;
//     }
//     set projeto(value){
//         this.#projeto = value;
//     }
    
// }

// const maria = new Bolsista("Maria", 132456, "IA");
// maria.projeto = "jogos";
// maria.matricula = 123456;
// console.log(maria);

class Person{
    constructor(first, last, age, gender, interests){
        this.#name = {
            'first' : first,
            'last' : last
        };
        this.age = age;
        this.gender = gender;
        this.interests = interests;
    }

    get name(){
        return `${this.#name.first} ${this.#name.last}`;
    }
    set name(value){
        this.#name = value;
    }
}
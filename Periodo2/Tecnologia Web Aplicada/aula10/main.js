// import { sayHi } from "./sayHi.js";

// sayHi("Joãzinho");




// import { user } from "./User.js";

// console.log(`Nome: ${user.nome}`);
// user.curso = "Análise e Desenvolvimento de Sistemas";
// console.log(`Curso: ${user.curso}`);



//console.log("ola"); //modulo sempre é executado como defer, ou seja, sempre vai ser executado por ultimo



// import {user,displayName} from "./User.js";

// console.log(user);
// displayName(user.name);


import SchoolUser  from "./school/User.js";
import SecurityUser from "./security/User.js"

let joazinho = new SchoolUser("Joãozinho");
let luizinho = new SchoolUser("Luizinho");

joazinho.displayName();
luizinho.displayName();

let security = new SecurityUser("admin","123456")
console.log(security);
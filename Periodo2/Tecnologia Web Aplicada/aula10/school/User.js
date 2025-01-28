// export let user = {
//     nome: "Luizinho",
//     curso: "ADS"
// };

// let user = {
//     name:"Luizinho"
// };

// function displayName() {
//     console.log(user.name);
// }

// export {user, displayName}

class User{
    constructor (name){
        this.name = name;
    }

    displayName(){
        console.log(this.name);
    }
}

export default User;
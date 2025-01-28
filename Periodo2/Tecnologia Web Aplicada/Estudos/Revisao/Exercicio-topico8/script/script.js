class Person {
    constructor(first, last, age, gender, interests) {
      this.name = {
        first,
        last
      };
      this.age = age;
      this.gender = gender;
      this.interests = interests;
    }

    get name(){
        return this.name;
    }
    set first(newFirst,){
        fir
    }
    get age(){
        return this.age;
    }
    set age(newAge){
        this.age=newAge;
    }
    get gender(){
        return this.gender;
    }
    set gender(newGender){
        this.gender=newGender;
    }
    get interests(){
        return this.interests;
    }
    set interests(newInterests){
        this.interests=newInterests;
    }
  
    greeting() {
      console.log(`Hi! I'm ${this.name.first}`);
    };
  
    farewell() {
      console.log(`${this.name.first} has left the building. Bye for now!`);
    };
  }
  
 const person = new Person("Rafael", "Campos", 22, 'm', "botafogo");


  
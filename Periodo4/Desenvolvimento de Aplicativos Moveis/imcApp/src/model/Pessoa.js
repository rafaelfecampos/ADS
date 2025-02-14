class Pessoa {
    constructor(nome,peso, altura){
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;

    }
    imc(){
        return this.peso/(this.altura*this.altura)
    }

    faixa(){
//         18.50 – 24.99: Peso Normal.
// 25.00 – 29.99: Pré-Obesidade.
// 30.00 – 34.99: Obesidade Grau I.
// 35.00 – 39.99: Obesidade Grau II.
// ≥40.00: Obesidade Grau III.
        let imc = this.imc();
        if(imc < 18.5){
            return "magro";
        }else if(imc <=29.99){
            return "Normal"
        }else if(imc<=34.99){
            return "Obesidade Grau 1"
        }else if(imc<=39.99){
            return "Obesidade Grau 2"
        }else{
            return "Obesidade Grau 3"
        }
    }
}

export default Pessoa;
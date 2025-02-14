class Combustivel{
    constructor(gasolina, alcool){
        this.gasolina = gasolina;
        this.alcool = alcool;
    }

    resultado(){
        return  this.alcool/this.gasolina;
    }

    maisVantajoso(){
        const calculo = this.resultado();
        if(calculo <= 0.7){
            return "Álcool é mais vantajoso!";
        }else{
            return "Gasolina é mais vantajoso!";
        }
    }

}

export default Combustivel;
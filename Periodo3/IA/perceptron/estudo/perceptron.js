class Perceptron {
    weights = []; //pesos
    lr = 0.1; //taxa de aprendizagem (não pode ser muito alta para nao ter falta de exatidao e nem muito baixa para nao demorar o calculo)
    consecutiveHints = 0; //variavel que recebe a quantidade de acertos consecutivos

    constructor(numberWeights){ //inicializando os weights com valores randomicos e numero de pesos
        this.weights = new Array(numberWeights);
        for(let i =0; i<this.weights.length; i++){
            this.weights[i] = random(-1, 1);
        }
    }

    train(inputs, target){ //treina o perceptron
        const guess = this.guess(inputs);
        const error = target - guess;
        //ajustar todos weights
        for(let i = 0; i < this.weights.length; i++){
            this.weights[i] += error * inputs[i] * this.lr; //o perceptron para de treinar quando o erro chega a 0 definitivamente
        }
        // console.log(error);
        if(error == 0){
            this.consecutiveHints++;
        }else{
            this.consecutiveHints = 0;
        }
    }

    //inputs --> entrada array de duas posições x1 e x2
    guess(inputs){
        let sum = 0;
        //aplicando a formula y  = x1 * w1 + x2 * w2
        for(let i = 0; i < this.weights.length;  i++){
            if(i==0)
                sum += inputs[i] *inputs[i]* this.weights[i];
            else
                sum += inputs[i] * this.weights[i];
        }
        // console.log(sum);
        const output = sign(sum);
        return output;
    }
    
    guessY(x){ //linha de classificação na visao do perceptron
        const w0 = this.weights[0];
        const w1 = this.weights[1];
        const w2 = this.weights[2];

        return -(w2 / w1) - (w0 / w1) * x;
    }

}
//função de ativação
function sign(num){
    return (num >= 0)? 1 : -1;
}
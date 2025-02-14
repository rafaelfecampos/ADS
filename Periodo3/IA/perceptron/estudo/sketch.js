let perceptron;

let points = new Array(100); //cria um array com capacidade de guardar 100 pontos
let trainning = true; //flag para verificar se ainda há necessidade de treinamento
let accuracy = 0.8; //precisao do acerto
let parar = false; //flag para parar de desenhar 
let points2 = new Array(100);
let count = 0; //conta a checagem do palpite do perceptron para os novos pontos
let acertos = 0; //conta os acertos do palpite do perceptron para os novos pontos

function setup(){
    createCanvas(550,550);
    //antes o perceptron era declarado com 2 agora tem que 3, pois o bias entra como elemento do input
    // perceptron = new Perceptron(2); //2 equivale ao numero necessário das coordenadas no plano cartesiano
    perceptron = new Perceptron(3);
    for(let i = 0; i < points.length; i++){
        points[i] = new Point(random(-1, 1), random(-1, 1)); //define os parametros do ponto aleatoriamente entre -1 e 1
        // points[i].debug();
    }

}

function draw(){
    background(220); //define a cor do fundo da tela
    for(let i = 0; i< points.length; i++) {
        points[i].show();
    }
    noStroke();
    for(let i = 0; i< points.length; i++){
        const pt = points[i];
        // método train sem bias
        /*const inputs = [pt.x, pt.y];
        const target = pt.label;
        const guess = perceptron.guess(inputs);*/
        //novo metodo train
        const inputs = [pt.x, pt.y, pt.bias]; //input com bias
        const target = pt.label;
        const guess = perceptron.guess(inputs);
        if(guess == target){
            fill(0, 255, 0);
        }else{
            fill(255, 0, 0);
        }
        ellipse(pt.getPixelX(), pt.getPixelY(), 15, 15);
    }
    // drawLine();
    if(trainning){
        trainSinglePoint();
    }else{
        criarPontos2();
        drawPoints2();
    }
}
function criarPontos2(){
    if(!parar){
        for(let i = 0; i< points2.length; i++){
            points2[i] = new Point(random(-1, 1), random(-1, 1));
        }
    }

    parar = true;
}

function drawPoints2(){
    if(!trainning){
        for(let i = 0; i< points.length; i++) {
            points2[i].show();
        }
        noStroke();
        for(let i = 0; i< points2.length; i++) {            
            const pt = points2[i];
            const inputs = [pt.x, pt.y, pt.bias]; //input com bias
            const target = pt.label;
            const guess = perceptron.guess(inputs);
            if(guess == target){
                fill(0, 255, 0);
                if(count<points2.length){
                    count++;
                    acertos++;
                    // console.log(`contador: ${count}`+'\n'+`acertos: ${acertos}`);
                }
            }else{
                fill(255, 0, 0);
                if(count<points2.length){
                    count++;
                    // console.log(`contador: ${count}`+'\n'+`acertos: ${acertos}`);

                }
            }
            if(count == 100){
                console.log(`Precisao de acertos para novos pontos: ${acertos/count}`);
                count ++;
            }
            ellipse(pt.getPixelX(), pt.getPixelY(), 15, 15);
        }
    }
}

function drawLine() {
    stroke(0);
    const p1 = new Point(-1, f(-1)); //construindo o primeiro ponto (-1,-1)
    const p2 = new Point(1, f(1));//construindo o segundo ponto (1,1)
    line(p1.getPixelX(), p1.getPixelY(), p2.getPixelX(), p2.getPixelY());
    const guessP1 = new Point(-1, perceptron.guessY(-1));
    const guessP2 = new Point(1, perceptron.guessY(1));
    line(guessP1.getPixelX(), guessP1.getPixelY(), guessP2.getPixelX(), guessP2.getPixelY());
}

let trainningIndex = 0; //guarda o index do ponto que vai ser treinado

function trainSinglePoint(){
    const pt = points[trainningIndex];
    const inputs = [pt.x, pt.y, pt.bias];
    perceptron.train(inputs, pt.label);
    trainningIndex++;
    if(trainningIndex == points.length){
        trainningIndex = 0;
    }
    if(perceptron.consecutiveHints >= (points.length*accuracy)){
        console.log("parou");
        trainning = false;
    }
}

//##DOCUMENT OBJECT MODEL (DOM)##

/*console.log(window);

console.log(document);*/

/*let titulo = document.getElementById('titulo1')
titulo.innerText = "MARIANA";
console.log(titulo);

let paragrafo = document.getElementById('paragrafo');
let mariana = {
    quantidade: 10,
    conta(){
        let letra = '';
        let contagem = [];
        let i = 1;
        while ( i <= this.quantidade){
            contagem.push(` é ${i} `);
            letra += 
            `Mariana conta ${i} \n`+
            `Mariana conta ${i}: ${contagem}, é!\n`;
            letra += `Ana, viva a Mariana, viva a Mariana \n\n`;
            i++;
        };
        return letra;
    }
};
paragrafo.innerText = mariana.conta();
console.log(paragrafo);*/

// let paragrafo = document.getElementsByTagName('p');
// console.log(paragrafo);





let elefante = {
    quantidade : 10,
    conta(){
        let musica = "1 elefante incomoda muita gente\n";
        let incomodam = [`incomodam `];
        for (let i = 2; i <= this.quantidade; i++){
            incomodam.push(`incomodam `);

            if ( i % 2 == 1 ){
                musica += `${i} elefantes incomodam muita gente\n`;           
            }else{
                musica += `${i} elefantes ${incomodam} muito mais! \n`;
            }
        }

        musica +=`\n`;

        for (let i = this.quantidade; i >= 2; i--){
            if ( i % 2 == 0 ){
                musica += `${i} elefantes incomodam muita gente\n`;           
            }else{
                musica += `${i} elefantes ${incomodam} muito menos! \n`;
            }
            incomodam.pop();
        }

        musica += "1 elefante incomoda muito menos\n";
        console.log(musica);
    }
};

elefante.conta();
import Aresta from "./Aresta.js";

export default class Vertice{
    valor="";
    heuristica = null;
    adjacentes=[];

    constructor(valor, heuristica){
        this.valor = valor;
        this.heuristica = heuristica;
    }

    adicionarAresta(destino, peso){
        this.adjacentes.push(new Aresta(this, destino, peso));
    }

    buscaAresta(vertice){
        let arestaEncontrada = null;
        this.adjacentes.forEach( aresta => {
            if(aresta.destino == vertice){
                arestaEncontrada = aresta;
            }
        })
        return arestaEncontrada;
    }

   
}
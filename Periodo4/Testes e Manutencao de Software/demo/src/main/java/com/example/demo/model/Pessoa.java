package com.example.demo.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class Pessoa {
    private String nome;
    private double peso, altura;

    public double imc() throws Exception {
        if(peso <=0){
            throw new Exception("Peso não pode ser menor ou igual a zero ");
        }
        if(altura <=0){
            throw new Exception("Altura não pode ser menor ou igual a zero");
        }
        return (peso/(altura*altura));
    }

    public String faixa() throws Exception {
        double fx = imc();
        if(fx < 18.5){
            return "magrao";
        }else if(fx <= 24.99){
            return "normal";
        }else if(fx <= 29.99){
            return "Pré-obesidade";
        }else if(fx <= 34.99){
            return "Obesidade Grau 1";
        }else if(fx <= 39.99){
            return "Obesidade Grau 2";
        }else{
            return "Obesidade Grau 3";
        }
    }
}

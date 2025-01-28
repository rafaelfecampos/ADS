package org.example;

import java.util.Scanner;


public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Votacao votacao = new Votacao();
        boolean continuar = true;
        while (continuar){
            Aluno aluno = new Aluno();
            System.out.print("Digite seu nome: ");
            aluno.setNome(sc.next());
            System.out.print("Voto: ");
            aluno.setVoto(sc.next());
            votacao.validarVoto(aluno);
            System.out.println("Continuar? (S/N0");
            if(!sc.next().toUpperCase().equals("S")){
                continuar=false;
            }
        }
        votacao.contarVotos();
        System.out.println("Vencedor: " + votacao.vencedor().getNome());

    }
}
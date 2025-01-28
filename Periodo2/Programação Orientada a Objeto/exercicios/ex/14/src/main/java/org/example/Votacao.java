package org.example;

import java.util.ArrayList;

public class Votacao {
    private ArrayList<Aluno> alunos;

    public Votacao() {
        alunos = new ArrayList<>();
    }
    public void validarVoto(Aluno a){
        if(!a.getVoto().equals(a.getNome())){
            alunos.add(a);
        }
        else{
            a.setVoto("Voto Inválido");
            System.out.println(a.getVoto());
            alunos.add(a);
        }
    }
    public Aluno vencedor() {
        Aluno maisVotado = alunos.get(0);
        for (Aluno a : alunos) {
            if (a.getnVotos()>maisVotado.getnVotos()) {
                maisVotado = a;
            }
        }
        return maisVotado;
    }

    public void contarVotos(){
        for(int i=0; i<alunos.size();i++){
            for (int j=0; j<alunos.size();j++){
                if(i!=j){
                    if(alunos.get(i).getNome().equals(alunos.get(j).getVoto()))
                        alunos.get(i).contarVoto();
                }
            }
        }
    }
}

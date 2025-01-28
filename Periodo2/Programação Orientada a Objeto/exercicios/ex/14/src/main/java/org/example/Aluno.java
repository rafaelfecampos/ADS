package org.example;

public class Aluno {
    private String nome, voto;
    private int nVotos=0;

    public Aluno() {
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getVoto() {
        return voto;
    }

    public void setVoto(String voto) {
        this.voto = voto;
    }

    public int getnVotos() {
        return nVotos;
    }

    public void contarVoto() {
        nVotos++;
    }

}

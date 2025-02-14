package com.example.demo.service;

import com.example.demo.DAO.AlunoDAO;
import com.example.demo.model.Aluno;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.sql.SQLException;
import java.util.List;

@Service
public class AlunoService {
    @Autowired
    AlunoDAO aDao;
    public List<Aluno> alunosAprovados(){
        List<Aluno> lista = aDao.findByStatus("APROVADO");

        return lista;

    }

    public Aluno saveAluno(Aluno aluno) throws SQLException {
        if(aluno.getNome().isEmpty() || aluno.getNome().isBlank()){
            throw new SQLException("Nome não pode ser vazio!");
        }
        if(!aluno.getEmail().contains("@")){
            throw new SQLException("Email invalido!");
        }
        if(aluno.getNota1()<0 || aluno.getNota2()<0){
            throw new SQLException("Notas incorretas!");
        }

        return aDao.save(aluno);
    }
}

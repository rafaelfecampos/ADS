package com.example.demo.DAO;

import com.example.demo.model.Aluno;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface AlunoDAO extends JpaRepository<Aluno, Integer> {
    public List<Aluno> findByStatus(String status);

    Aluno findByNome(String jeffinho);
}

package com.example.demo.service;

import com.example.demo.DAO.AlunoDAO;
import com.example.demo.model.Aluno;
import org.junit.jupiter.api.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.ActiveProfiles;

import java.sql.SQLException;

@SpringBootTest
@ActiveProfiles("test")//aqui temos o teste definindo que a aplicação rodara o banco de test - definido pelo application-test.properties
public class AlunoServiceTest {
    @Autowired
    AlunoDAO aDAO;
    @Autowired
    AlunoService aService;

//    @BeforeEach
//    public void initBanco(){
//        Aluno a = new Aluno(1, "Zezin", "ze@ze", 10, 10, "APROVADO");
//		aDAO.save(a);
//		Aluno b = new Aluno(2, "Pedin", "ze@ze", 10, 10, "APROVADO");
//		aDAO.save(b);
//		Aluno c = new Aluno(3, "Carlin", "ze@ze", 3, 2, "REPROVADO");
//		aDAO.save(c);
//    }
//    @AfterEach
//    public void closeBanco(){
//        System.out.println("DEPOIS");
//        aDAO.deleteAll();
//    }
//    @BeforeAll
//    public static void initBanco2(){
//        System.out.println("ANTES");
//    }
//    @AfterAll
//    public static void closeBanco2(){
//        System.out.println("DEPOIS");
//    }
    @Test
    @DisplayName("Consulta número de alunos aprovados")
    public void teste01(){
        int esperado = 2;
        int resultado = aService.alunosAprovados().size();

        Assertions.assertEquals(esperado, resultado);
    }
//    @Test
//    @DisplayName("Salvar aluno válido")
//    public void teste02() throws SQLException {
//        Aluno a = new Aluno(4, "Jeffinho", "jeffin@jeffin", 8, 9, "APROVADO");
//        aService.saveAluno(a);
//        Aluno a1 = aDAO.findByNome("Jeffinho");
//
//        Assertions.assertEquals(a.getNome(), a1.getNome());
//    }
//    @Test
//    @DisplayName("Salvar aluno sem nome")
//    public void teste03(){
//        Aluno a = new Aluno(4, "", "jeffin@jeffin", 8, 9, "APROVADO");
//        try{
//            aService.saveAluno(a);
//            Assertions.fail("Falhou!!");
//        }catch (SQLException e){
//            Assertions.assertEquals("Nome não pode ser vazio!", e.getMessage());
//
//        }
//
//    }
}

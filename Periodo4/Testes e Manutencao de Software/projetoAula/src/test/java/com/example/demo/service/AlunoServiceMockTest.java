package com.example.demo.service;

import com.example.demo.Dao.AlunoDao;
import com.example.demo.model.Aluno;
import org.junit.jupiter.api.*;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.ActiveProfiles;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Optional;

@SpringBootTest
@ActiveProfiles("test")
public class AlunoServiceMockTest {
    @Mock
    AlunoDao aDao;
    @InjectMocks
    AlunoService aServ;

    @Test
    @DisplayName("consulta numero de alunos aprovados")
    public void teste01(){
        Aluno a = new Aluno(1,"Zezin",
                "ze@ze",10,8, "APROVADO");
        Aluno a1 = new Aluno(2,"PEdrin",
                "ze@ze",10,8, "APROVADO");
        ArrayList<Aluno> alunos = new ArrayList<>();
        alunos.add(a);
        alunos.add(a1);
        Mockito.when(aDao.findByStatus("APROVADO")).thenReturn(alunos);

        System.out.println(aServ.alunosAprovados().size());

        int esperado = 2;
        int resultado = aServ.alunosAprovados().size();
        Assertions.assertEquals(esperado, resultado);
    }


    @Test
    @DisplayName("Testar buscar pelo id do aluno existente")
    public void teste02(){
        Aluno a = new Aluno(1,"Zezin",
                "ze@ze",10,8, "APROVADO");

        Mockito.when( aDao.findById(1) ).thenReturn( Optional.of(a) );

        try {
             Optional<Aluno> res = aServ.buscarAlunoPorId(1);

             Assertions.assertEquals(a, res.get());
        } catch (SQLException e) {
            Assertions.fail("falhou o teste");
        }
    }
    @Test
    @DisplayName("Testar buscar pelo id do aluno não existente")
    public void teste03(){

        Mockito.when( aDao.findById(99) ).thenReturn( Optional.empty() );

        try {
            Optional<Aluno> res = aServ.buscarAlunoPorId(99);

            Assertions.fail("falhou o teste");

        } catch (SQLException e) {
            Assertions.assertEquals("Aluno não encontrado com o ID: 99", e.getMessage());
        }
    }



    @Test
    @DisplayName("Testar lançamento de notas acima de 10")
    public void teste04(){
        Aluno a = new Aluno(1,"Zezin",
                "ze@ze",10,4, "APROVADO");
        Aluno b = new Aluno(1,"Zezin",
                "ze@ze",10,8, "APROVADO");

        Mockito.when( aDao.findById(1) ).thenReturn( Optional.of(a) );
        Mockito.when( aDao.save( new Aluno(1,"Zezin",
                "ze@ze",10,8, "APROVADO") ) )
                .thenReturn(
                        new Aluno(1,"Zezin",
                "ze@ze",10,8, "APROVADO")
        );

        Mockito.when( aDao.save( Mockito.any() ) )
                .thenReturn( null );


        try {
            Aluno res = aServ.atualizarNotas(1, 10, 8);
            System.out.println(res.getNota1()+" "+res.getNota2());
            System.out.println(b.getNota1()+" "+b.getNota2());
            Assertions.assertEquals(res, b);
        } catch (SQLException e) {
            Assertions.fail("falhou o teste");
        }
    }



}

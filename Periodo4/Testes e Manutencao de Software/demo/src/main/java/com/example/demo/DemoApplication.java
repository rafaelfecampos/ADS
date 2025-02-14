package com.example.demo;

import com.example.demo.DAO.AlunoDAO;
import com.example.demo.model.Aluno;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DemoApplication implements CommandLineRunner {

	public static void main(String[] args) {
		SpringApplication.run(DemoApplication.class, args);
	}
	@Autowired
	AlunoDAO alunoDAO;


	@Override
	public void run(String... args) throws Exception {
//		Aluno a = new Aluno(1, "Zezin", "ze@ze", 10, 0, "APROVADO");
//		alunoDAO.save(a);
//		Aluno b = new Aluno(2, "Pedin", "ze@ze", 10, 0, "APROVADO");
//		alunoDAO.save(b);
//		Aluno c = new Aluno(3, "Carlin", "ze@ze", 10, 0, "APROVADO");
//		alunoDAO.save(c);

//		System.out.println(alunoDAO.findAll().size());
	}
}

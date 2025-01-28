/*Relação funcionário*/
select * from funcionario where cpf_supervisor is null;
select * from funcionario where sexo != "F";
select * from funcionario where (cpf_supervisor is not null) or (salario > 35000);
select * from funcionario where (sexo = "M") and (datanasc > '1962-01-01');
select * from funcionario where (unome = "Silva") or (pnome = "Jorge");
select * from funcionario where dnr is null;

/*Relação Departamento*/
select * from departamento where cpf_gerente is null;
select * from departamento where dnome = "Matriz";
select * from departamento where data_inicio_gerente is null;

/*Relação Dependente*/
select * from dependente where parentesco = "Esposa";
select * from dependente where (parentesco = "Esposa") or (parentesco = "Filha");
select * from dependente where fcpf = 12345678966;
select * from dependente where (sexo = "M") or (parentesco = "Filho");
/*Relação Funcionário*/
select * from funcionario where cpf_supervisor is null;
select * from funcionario where sexo != 'F';
select * from funcionario where cpf_supervisor is not null or salario > 35000;
select * from funcionario where sexo='M' and datanasc > '1962-01-01';
select * from funcionario where unome='Silva' or pnome='Jorge';
select * from funcionario where dnr is null;

/*Relação departamento*/
select * from departamento where cpf_gerente is null;
select * from departamento where dnome = 'Matriz';
select * from departamento where data_inicio_gerente is null;

/*Relação dependente*/
select * from dependente where parentesco = 'esposa';
select * from dependente where parentesco = 'esposa' or parentesco = 'filha';
select * from dependente where fcpf = 12345678966;
select * from dependente where sexo = 'M' or parentesco = 'filho';

/*Relação projeto*/
select * from projeto where projlocal = 'são paulo';
select * from projeto where projlocal = 'são paulo' and (dnum = '5' or dnum = '1');

/*Relação localização_dep*/
select * from localizacao_dep where dlocal='São Paulo';
select * from localizacao_dep where dlocal='são paulo' and (dnumero = 5 or dnumero = 1);

/*Relação trabalha_em*/
select * from trabalha_em where horas > 20;
select * from trabalha_em where horas > 10 or pnr = 3;
select * from trabalha_em where fcpf = 98765432168 and pnr = 30;
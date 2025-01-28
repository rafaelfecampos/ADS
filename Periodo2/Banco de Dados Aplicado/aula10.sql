select truncate(avg(salario),2) as media_salario
from funcionario;

/*Traga o numero de funcionarios do departamento de pesquisa*/
select count(*)
from funcionario f inner join departamento d on f.dnumero = d.dnumero
where d.nome='Pesquisa'
having count(*)>0;

select count(*)
from funcionario f inner join departamento d on f.dnumero = d.dnumero
where d.nome='Pesquisa'
having count(*)>0;

select f.pnome, count(*)
from funcionario f inner join dependente d on f.cpf = d.fcpf
group by f.cpf
having count(*)>=2;

select dnumero, count(*),avg(salario)
from funcionario
group by dnumero

/*Recupere os dados dos funcionarios que possuem o maior salario*/
select *
from funcionario
where salario = (select max(salario) from funcionario);


/*Recupere todas as informações do funcionário mais velho*/
select *
from funcionario
where datanasc = (select min(datanasc) from funcionario);

select pnome, salario
from funcionario
where salario>=30000;

/*eliminando as repetições*/
select pnome, sexo, datanasc
from funcionario
union 
select nome_dependente, sexo, datanasc
from dependente;

/*trazendo as repetições*/
select pnome, sexo, 'Funcionario' as Classificacao
from funcionario
union all
select nome_dependente, sexo, datanasc
from dependente;
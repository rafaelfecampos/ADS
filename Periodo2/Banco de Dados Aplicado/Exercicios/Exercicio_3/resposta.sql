select distinct parentesco
from dependente;

select distinct nivel_graduacao
from cargo;

select nome, sexo
from empregado
where codigo_dep = '306' and nome like "%a%" 
order by nome asc;

select data_nasc, nome
from empregado
where sexo="F" 
order by data_nasc desc;

select nome
from empregado
where codigo_empregado not in(select codigo_empregado from dependente);

select *
from empregado
where codigo_dep not in(select codigo_dep from departamento
where local ='Rio de Janeiro');

select nome_cargo
from cargo
where codigo_cargo in (select codigo_cargo from empregado);

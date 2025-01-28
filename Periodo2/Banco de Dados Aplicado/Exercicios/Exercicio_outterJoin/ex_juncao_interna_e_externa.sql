/*QUESTÃO 01: Traga o nome de todos os filmes, os que foram locados por algum cliente, 
traga também o nome do cliente.Traga também o nome de todos os clientes, os que locaram
  ou não filmes, caso tenha locado o nome do filme deverá aparecer.*/
  select titulo, nome_cliente
  from filme f left join locacao l on f.codigo_filme = l.codigo_filme left join
  cliente c on l.codigo_cliente = c.codigo_cliente
  union
  select titulo, nome_cliente
  from filme f right join locacao l on f.codigo_filme = l.codigo_filme right join
  cliente c on l.codigo_cliente = c.codigo_cliente;

/*QUESTÃO 02: Traga o nome dos gêneros que não estão em nenhum filme. Utilize junção 
externa.*/
select nome_genero
from genero g left join filme_genero fg on g.codigo_genero = fg.codigo_genero
where codigo_filme is null;

/*QUESTÃO 03: Traga o nome de todos os diretores. Caso ele tenha dirigido algum filme, 
traga o nome do filme.*/
select nome_diretor, titulo
from filme f right join filme_diretor fd on f.codigo_filme = fd.codigo_filme right
join diretor d on fd.codigo_diretor = d.codigo_diretor;

/*QUESTÃO 04: Traga o nome e cpf de todos os clientes, caso ele tenha locado algum 
filme, traga o titulo do filme e a data de locação.*/
select nome_cliente, cpf, titulo, data_locacao
from cliente c left join locacao l on c.codigo_cliente = l.codigo_cliente
left join filme f on l.codigo_filme = f.codigo_filme;

/*QUESTÃO 05: Traga o título dos filmes, juntamente com o nome dos atores que atuaram
 nele.*/
 select titulo, nome_ator
 from filme f inner join filme_ator fa on f.codigo_filme = fa.codigo_filme
 inner join ator a on fa.codigo_ator = a.codigo_ator;
 
/*QUESTÃO 06: Traga o nome dos clientes que alugaram filmes do gênero comédia.*/
select nome_cliente
from cliente natural join locacao natural join filme natural join filme_genero
natural join genero
where nome_genero='comédia';


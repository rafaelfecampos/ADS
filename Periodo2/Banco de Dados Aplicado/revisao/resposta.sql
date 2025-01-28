/*questao 1*/
select p.*
from produto p left join produto_vendido pv
on p.ID_PRODUTO = pv.ID_PRODUTO
where pv.NR_VENDA is null;

/*questao 2*/
select c.*
from cliente c left join venda v
on c.ID_CLIENTE=v.ID_CLIENTE
where NR_VENDA is null;

/*questao 3*/
select *
from produto
where ESTOQUE=(select max(ESTOQUE) from produto);

/*questao 4*/
select *
from produto
where PRECO_UNITARIO=(select min(PRECO_UNITARIO) from produto);

/*questao 5*/
select v.NR_VENDA, sum(pv.QUANTIDADE) as qdade_produtos
from venda v inner join produto_vendido pv
on v.NR_VENDA=pv.NR_VENDA
group by v.NR_VENDA
having qdade_produtos>5;

/*questao 6*/
select nr_venda, sum(quantidade)
from produto_vendido
group by NR_VENDA;

/*questao 7*/
select c.*, count(v.ID_CLIENTE) as quantidade_compras
from cliente c left join venda v
on c.ID_CLIENTE=v.ID_CLIENTE
group by c.ID_CLIENTE;
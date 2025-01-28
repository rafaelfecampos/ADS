select numeroassento, classe
from assento
where status = "disponivel";

select fabricante, anofabricacao
from aeronave
where capacidade >= 200;

select numerovoo, horariosaida
from voo
where cidadedestino = 4567;

select preco
from reserva
where codigovoo = 1100;

select codigocliente
from reserva
where datareserva ='2014-11-10';

select codigocidade
from cidade
where nomecidade = "belo horizonte";

select codigoaeronave, prefixo
from aeronave
where anofabricacao > 2013;

select numeroassento
from reserva
where preco>1000;

select numerovoo
from voo
where horariosaida > '22:00:00';

select endereco, telefone
from cliente
where nomecliente = "Joice Leite";
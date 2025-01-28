select animais.nome, empregados.nome
from animais, empregados
where idcuidador = idempregado;

select c.nome
from clientes c, provedores p
where c.idCliente = p.idCliente;

select a.nome, a.dataSaida
from animais a, eventoanimais e
where a.idAnimal = e.idAnimal and e.descricao='falecimento';

select a.*
from animais a, especies e, alimentacao ali
where a.dataSaida is null and a.idEspecie = e.idEspecie and e.idAlimentacao = ali.idAlimentacao and ali.nome="carnivoros";

select a.nome, e.nomecomum
from animais a, especies e, eventoanimais ev
where a.idEspecie = e.idEspecie and a.idAnimal = ev.idEventoAnimal and ev.descricao="Trasnferência para outro zoológico";

select p.nome, estoque, c.nome
from produtos p, provedores pro, sociedades s, clientes c
where descricao='ong' and p.idprovedor = pro.idprovedor and pro.tiposociedade = idtiposociedade and idtiposociedade = c.tiposociedade;



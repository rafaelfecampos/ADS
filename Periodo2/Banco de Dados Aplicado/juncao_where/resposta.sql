select a.nome, e.nome
from animais a, empregados e
where a.idCuidador=e.idEmpregado;

select c.nome
from clientes c, provedores p
where c.idCliente=p.idCliente;

select a.nome, ea.data
from animais a, eventoanimais ea
where a.idAnimal=ea.idAnimal and ea.descricao='falecimento';

select a.nome, a.dataNascimento, e.nome, m.descricao
from animais a, empregados e, medicacao m
where a.idCuidador=e.idEmpregado and a.idMedicacao=m.idMedicacao;

select a.*
from animais a, especies e, alimentacao ali
where a.idEspecie=e.idEspecie and e.idAlimentacao=ali.idAlimentacao and ali.nome='Carnívoros' and a.dataSaida is null;

select a.nome, e.nomeComum
from animais a, especies e, eventoanimais ea, tipoeventos te
where a.idEspecie=e.idEspecie and a.idAnimal=ea.idAnimal and ea.tipoEvento=te.idTipo and te.descricao='Translado';

select p.nome, estoque, c.nome
from produtos p, provedores pro, sociedades s, clientes c
where descricao='ong' and p.idprovedor = pro.idprovedor and pro.tiposociedade = idtiposociedade and idtiposociedade = c.tiposociedade;



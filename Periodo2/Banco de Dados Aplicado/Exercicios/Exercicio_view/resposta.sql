create view view1 as
select nome, sobrenome, idturma
from instrutor i inner join turma t on i.idinstrutor = t.instrutor_idinstrutor
order by nome asc;

create view view2 as
select i.*, count(*) as qtade_turmas
from instrutor i inner join turma t on i.idinstrutor = t.instrutor_idinstrutor
group by i.idinstrutor
having  qtade_turmas>2;

create view view3 as
select a.nome, count(*) as qtade_turmas
from atividade a inner join turma t
on a.idatividade = t.atividade_idatividade
group by a.nome
order by a.nome asc;

create view view4 as
select *
from aluno
where numMatricula not in( select aluno_matricula
from matricula);

create view view5 as
select a.*, t.idturma
from aluno a inner join matricula m
on a.numMatricula = m.aluno_matricula inner join turma t
on m.turma_idturma = t.idturma
order by a.nome asc;

create view view6 as
select a.*
from aluno a inner join matricula m
on a.numMatricula = m.aluno_matricula inner join turma t
on m.turma_idturma = t.idturma inner join atividade ati
on t.atividade_idatividade = ati.idatividade
where ati.nome = 'Pilates';

create view view7 as
select a.nome, count(*) as quantidade_atividade
from aluno a inner join matricula m
on a.numMatricula = m.aluno_matricula inner join turma t
on m.turma_idturma = t.idturma inner join atividade ati
on t.atividade_idatividade = ati.idatividade
group by a.numMatricula;

select * from view7;

create view view8 as
select avg(a.altura)
from aluno a inner join matricula m
on a.numMatricula = m.aluno_matricula inner join turma t
on m.turma_idturma = t.idturma inner join atividade ati
on t.atividade_idatividade = ati.idatividade
where ati.nome = 'volei';
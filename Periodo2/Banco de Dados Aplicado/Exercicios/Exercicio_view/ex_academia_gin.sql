/*QUESTÃO 01: Crie e exiba uma visão que recupere 
os nomes e sobrenome dos instrutores e o código 
das turmas que eles ministram. 
Ordene pelo nome do instrutor.
(1008 linhas retornadas) */
create view visao1 as 
select i.idinstrutor, nome,sobrenome, idturma
from instrutor i inner join turma t on
i.idinstrutor = t.instrutor_idinstrutor
order by nome asc;

select * from visao1;

/*QUESTÃO 02: Crie e exiba uma visão que recupere
os dados dos instrutores que dão aula para mais 
de 2 turmas. (47 linhas retornadas)*/
create view visao2 as
select i.*, count(*) as qdade_turmas
from instrutor i inner join turma t
on i.idinstrutor = t.instrutor_idinstrutor
group by i.idinstrutor
having qdade_turmas>2;

select * from visao2;

/*QUESTÃO 03: Crie e exiba uma visão que recupere
os nomes das atividades com a quantidade de 
turmas que a praticam. 
Ordene pelo nome da atividade. 
(40 linhas retornadas)*/
create view visao3 as
select a.nome, count(*)
from atividade a inner join turma t
on a.idatividade = t.atividade_idatividade
group by a.idatividade
order by a.nome;

select * from visao2;

/*QUESTÃO 04: Crie e exiba uma visão que recupere 
os dados dos alunos não matriculados. 
(14247 linhas retornadas)*/
create view visao4 as
select *
from aluno
where numMatricula not in(select aluno_matricula
from matricula);

select * from visao4;

select a.*
from aluno a left join matricula m
on a.numMatricula = m.aluno_matricula
where m.aluno_matricula is null;


/*QUESTÃO 05: Crie e exiba uma visão que recupere 
os dados dos alunos e os códigos das turmas que 
eles participam. Ordene pelo nome do aluno. 
(2656 linhas retornadas)*/
create view visao5 as
select a.*, m.turma_idturma
from aluno a inner join matricula m
on a.numMatricula = m.aluno_matricula
order by a.nome;
select * from visao5;

/*QUESTÃO 06: Crie e exiba uma visão que recupere 
os dados dos alunos que praticam Pilates. 
(81 linhas retornadas)*/
create view visao6 as
select a.*
from aluno a inner join matricula m on
a.numMatricula = m.aluno_matricula inner join
turma t on m.turma_idturma = t.idturma inner join
atividade atv on 
t.atividade_idatividade = atv.idatividade
where atv.nome='Pilates';
select * from visao6;

/*QUESTÃO 07: Crie e exiba uma visão que recupere 
a quantidade de atividades que cada aluno pratica.
 (16730 linhas retornadas)*/
 create view visao7 as
 select a.numMatricula, a.nome, a.sobrenome, 
 count(atv.idatividade)
 from aluno a inner join matricula m on
 a.numMatricula = m.aluno_matricula inner join
 turma t on m.turma_idturma = t.idturma inner join
 atividade atv on 
 t.atividade_idatividade = atv.idatividade
 group by a.numMatricula;
 
 select * from visao7;

/*QUESTÃO 08: Crie e exiba uma visão que recupere 
a altura média dos alunos que praticam vôlei. 
(1 linha retornada)*/
create view visao8 as
select avg(altura)
from aluno a inner join matricula m on
a.numMatricula = m.aluno_matricula inner join
turma t on m.turma_idturma = t.idturma inner join
atividade atv on t.atividade_idatividade =
atv.idatividade
where atv.nome='volei';
select * from visao8;

select *
from aluno a inner join matricula m on
a.numMatricula = m.aluno_matricula inner join
turma t on m.turma_idturma = t.idturma inner join
atividade atv on t.atividade_idatividade =
atv.idatividade;

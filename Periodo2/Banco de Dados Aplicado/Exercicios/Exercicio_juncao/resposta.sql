select nomearea
from area;

select nomemunicipio
from municipio
where siglauf = 'mg';

select nomeIES
from ies inner join categoria cat on ies.codcategoria = cat.codcategoria
where nomecategoria = 'Privada com fins lucrativos';

select nomeIES, conceitoFaixa
from ies join resultado r on ies.codIES = r.codIES inner join modalidade m on r.codModalidade = m.codModalidade
where anoEnade = 2017 and m.nomeModalidade = 'educacao a distância';

select nomeIES, nomeArea
from ies inner join resultado r on  ies.codIES = r.codIES inner join area a on r.codArea = a.codArea
where conceitoFaixa = 5 and nomeArea = "TECNOLOGIA EM ANÁLISE E DESENVOLVIMENTO DE SISTEMAS";

select nomeIES, nomeArea, conceitoFaixa
from ies inner join resultado r on  ies.codIES = r.codIES inner join area a on r.codArea = a.codArea inner join municipio m on r.codMunicipio = m.codMunicipio
where conceitoFaixa = 5 and anoEnade = 2017 and nomeMunicipio = 'juiz de fora';

select nomeIES, conceitoContinuo, conceitoFaixa
from ies inner join resultado r on ies.codIES = r.codIES inner join area a on a.codArea = r.codArea inner join municipio m on m.codMunicipio = r.codMunicipio
where nomeArea = "TECNOLOGIA EM ANÁLISE E DESENVOLVIMENTO DE SISTEMAS" and nomeMunicipio = "Juiz de Fora";

select nomeIES, nomeArea, numInscritos, numParticipantes, conceitoFaixa
from ies inner join resultado r on ies.codIES = r.codIES
inner join area a on a.codArea = r.codArea
inner join municipio m on m.codMunicipio = r.codMunicipio
where conceitoFaixa < 3 and nomeMunicipio = 'juiz de fora';

select nomeies, nomearea, numinscritos, numparticipantes, conceitofaixa
from ies inner join resultado r on ies.codies = r.codies
inner join municipio m on m.codmunicipio = r.codmunicipio inner join
area a on a.codarea = r.codarea
where conceitofaixa<3 and nomemunicipio='Juiz de Fora';



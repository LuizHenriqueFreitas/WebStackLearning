-- listar filmes com ano e nome
SELECT Nome, ano 
	FROM filmes;

-- Listar filmes com ano, nome e duração ordenado 
-- do ano mais antigo ao mais recente
SELECT ano, Nome, duracao 
	from filmes
	ORDER BY ano;

-- buscando o filme "De Volta para o Futuro" com ano e duração
select Nome, ano, duracao
	from filmes 
	where nome = 'De Volta para o Futuro';

-- buscar filmes lançados em 1997
select Nome, ano, duracao
	from filmes
	where ano = 1997;

-- buscar filmes lançados após anos 2000
select nome, ano, duracao
	from filmes
	where ano > 2000;

-- buscar filmes com duração entre 100 e 150 ordenado crescente por duração
select nome, ano, duracao
	from filmes
	where duracao > 100 and duracao < 150
	order by duracao;

-- buscar quantidade de filmes lançados por ano, agrupado por ano, ordenado pela duracao em ordem decrescente
select ano, count(*) as quantidade
	from filmes
	group by ano
	order by quantidade DESC;

-- buscar os atores masculinos retornando o primeiro e ultimo nomes
select primeiro_nome as PrimeiroNome, ultimo_nome as UltimoNome, genero 
	from atores
	where genero = 'M';

-- buscar atores femininas, retornando primeiro e ultimo nome ordenado pelo primeiro nome
select primeiro_nome as PrimeiroNome, ultimo_nome as UltimoNome, genero 
	from atores
	where genero = 'F'
	order by primeiro_nome;

-- busca o nome do filme e o genero
SELECT f.nome, g.genero
	FROM filmes f
	INNER JOIN filmes_genero fg ON f.id = fg.id_filme
	INNER JOIN generos g ON fg.id_genero = g.id;

-- buscar o nome do filmes do genero mistério
select f.nome, g.genero
	from filmes f
	inner join filmes_genero fg on f.id = fg.id_filme 
	inner join generos g on fg.id_genero = g.id
	where genero = 'Mistério';

-- buscar o nome do filme e os atores trazendo primeiro nome, ultimo nome e seu papel
select f.nome, a.primeiro_nome, a.ultimo_nome, ef.papel
	from elenco_filme ef
	inner join filmes f on ef.id_filme = f.id
	inner join atores a on ef.id_ator  = a.id;

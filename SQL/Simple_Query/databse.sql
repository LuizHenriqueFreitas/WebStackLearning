-- Criar banco de dados
CREATE DATABASE filmes;

-- Conectar ao banco (no pgAdmin, selecione o banco "filmes" na esquerda)

-- Tabela Atores
CREATE TABLE atores (
    id SERIAL PRIMARY KEY,
    primeiro_nome VARCHAR(20),
    ultimo_nome VARCHAR(20),
    genero VARCHAR(1)
);

-- Tabela Filmes
CREATE TABLE filmes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50),
    ano INT,
    duracao INT
);

-- Tabela Generos
CREATE TABLE generos (
    id SERIAL PRIMARY KEY,
    genero VARCHAR(20)
);

-- Tabela ElencoFilme
CREATE TABLE elenco_filme (
    id SERIAL PRIMARY KEY,
    id_ator INT NOT NULL,
    id_filme INT,
    papel VARCHAR(30),
    CONSTRAINT fk_elenco_ator FOREIGN KEY (id_ator) REFERENCES atores(id)
);

-- Tabela FilmesGenero
CREATE TABLE filmes_genero (
    id SERIAL PRIMARY KEY,
    id_genero INT,
    id_filme INT,
    CONSTRAINT fk_filmes_genero_genero FOREIGN KEY (id_genero) REFERENCES generos(id),
    CONSTRAINT fk_filmes_genero_filme FOREIGN KEY (id_filme) REFERENCES filmes(id)
);

-- Adicionar constraint FK em elenco_filme para filmes
ALTER TABLE elenco_filme
ADD CONSTRAINT fk_elenco_filme FOREIGN KEY (id_filme) REFERENCES filmes(id);

-- Inserir dados em Atores
INSERT INTO atores (id, primeiro_nome, ultimo_nome, genero) VALUES
(1, 'James', 'Stewart', 'M'),
(2, 'Deborah', 'Kerr', 'F'),
(3, 'Peter', 'OToole', 'M'),
(4, 'Robert', 'DeNiro', 'M'),
(6, 'Harrison', 'Ford', 'M'),
(7, 'Stephen', 'Baldwin', 'M'),
(8, 'Jack', 'Nicholson', 'M'),
(9, 'Mark', 'Wahlberg', 'M'),
(10, 'Woody', 'Allen', 'M'),
(11, 'Claire', 'Danes', 'F'),
(12, 'Tim', 'Robbins', 'M'),
(13, 'Kevin', 'Spacey', 'M'),
(14, 'Kate', 'Winslet', 'F'),
(15, 'Robin', 'Williams', 'M'),
(16, 'Jon', 'Voight', 'M'),
(17, 'Ewan', 'McGregor', 'M'),
(18, 'Christian', 'Bale', 'M'),
(19, 'Maggie', 'Gyllenhaal', 'F'),
(20, 'Dev', 'Patel', 'M'),
(21, 'Sigourney', 'Weaver', 'F'),
(22, 'David', 'Aston', 'M'),
(23, 'Ali', 'Astin', 'F');

-- Inserir dados em Generos
INSERT INTO generos (id, genero) VALUES
(1, 'Ação'),
(2, 'Aventura'),
(3, 'Animação'),
(4, 'Biografia'),
(5, 'Comédia'),
(6, 'Crime'),
(7, 'Drama'),
(8, 'Horror'),
(9, 'Musical'),
(10, 'Mistério'),
(11, 'Romance'),
(12, 'Suspense'),
(13, 'Guerra');

-- Inserir dados em Filmes
INSERT INTO filmes (id, nome, ano, duracao) VALUES
(1, 'Um Corpo que Cai', 1958, 128),
(2, 'Os Inocentes', 1961, 100),
(3, 'Lawrence da Arábia', 1962, 216),
(4, 'O Franco Atirador', 1978, 183),
(5, 'Amadeus', 1984, 160),
(6, 'Blade Runner', 1982, 117),
(7, 'De Olhos Bem Fechados', 1999, 159),
(8, 'Os Suspeitos', 1995, 106),
(9, 'Chinatown', 1974, 130),
(10, 'Boogie Nights - Prazer Sem Limites', 1997, 155),
(11, 'Noivo Neurótico, Noiva Nervosa', 1977, 93),
(12, 'Princesa Mononoke', 1997, 134),
(13, 'Um Sonho de Liberdade', 1994, 142),
(14, 'Beleza Americana', 1999, 122),
(15, 'Titanic', 1997, 194),
(16, 'Gênio Indomável', 1997, 126),
(17, 'Amargo pesadelo', 1972, 109),
(18, 'Trainspotting - Sem Limites', 1996, 94),
(19, 'O Grande Truque', 2006, 130),
(20, 'Donnie Darko', 2001, 113),
(21, 'Quem Quer Ser um Milionário?', 2008, 120),
(22, 'Aliens, O Resgate', 1986, 137),
(23, 'Uma Vida sem Limites', 2004, 118),
(24, 'Avatar', 2009, 162),
(25, 'Coração Valente', 1995, 178),
(26, 'Os Sete Samurais', 1954, 207),
(27, 'A Viagem de Chihiro', 2001, 125),
(28, 'De Volta para o Futuro', 1985, 116);

-- Inserir dados em ElencoFilme
INSERT INTO elenco_filme (id, id_ator, id_filme, papel) VALUES
(1, 1, 1, 'John Scottie Ferguson'),
(2, 2, 2, 'Miss Giddens'),
(3, 3, 3, 'T.E. Lawrence'),
(4, 4, 4, 'Michael'),
(5, 6, 6, 'Rick Deckard'),
(6, 7, 8, 'McManus'),
(7, 9, 10, 'Eddie Adams'),
(8, 10, 11, 'Alvy Singer'),
(9, 11, 12, 'San'),
(10, 12, 13, 'Andy Dufresne'),
(11, 13, 14, 'Lester Burnham'),
(12, 14, 15, 'Rose DeWitt Bukater'),
(13, 15, 16, 'Sean Maguire'),
(14, 16, 17, 'Ed'),
(15, 17, 18, 'Renton'),
(16, 19, 20, 'Elizabeth Darko'),
(17, 20, 21, 'Older Jamal'),
(18, 21, 22, 'Ripley'),
(19, 13, 23, 'Bobby Darin'),
(20, 8, 9, 'J.J. Gittes'),
(21, 18, 19, 'Alfred Borden');

-- Inserir dados em FilmesGenero
INSERT INTO filmes_genero (id, id_genero, id_filme) VALUES
(1, 1, 22),
(2, 2, 17),
(3, 2, 3),
(4, 3, 12),
(5, 5, 11),
(6, 6, 8),
(7, 6, 13),
(8, 7, 26),
(9, 7, 28),
(10, 7, 18),
(11, 7, 21),
(12, 8, 2),
(13, 9, 23),
(14, 10, 7),
(15, 10, 27),
(16, 10, 1),
(17, 11, 14),
(18, 12, 6),
(19, 13, 4);
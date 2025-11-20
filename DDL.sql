-- ADICIONAR E EDITAR AS TABELAS E ORDEM

-- ENTIDADES
CREATE TABLE Pessoa (
	UCI_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	data_nascimento DATE,
	nome varchar(64) NOT NULL,
	nacionalidade varchar(64) NOT NULL
);
CREATE TABLE Competicao (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	organizador varchar(64) NOT NULL,
	nome varchar(64) NOT NULL,
	data_inicio DATE NOT NULL,
	data_fim DATE NOT NULL,
	n_etapas int NOT NULL
);
CREATE TABLE Patrocinador (
	nome varchar(64) NOT NULL PRIMARY KEY,
	contacto varchar(64)
);
CREATE TABLE Etapa (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	duracao TIME NOT NULL,
	num_etapa int NOT NULL,
	distancia float NOT NULL
);
CREATE TABLE Classificacao (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	diferenca_vencedor float NOT NULL,
	posicao int NOT NULL
);
GO

CREATE TABLE DiretorDesportivo (
	UCI_ID int NOT NULL PRIMARY KEY,
	FOREIGN KEY (UCI_ID) REFERENCES Pessoa(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Ciclista (
	UCI_ID int NOT NULL PRIMARY KEY,
	num_dorsal int NOT NULL,
	FOREIGN KEY (UCI_ID) REFERENCES Pessoa(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Equipa (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	pais_origem varchar(64),
	num_ciclistas int NOT NULL,
	nome varchar(64) NOT NULL UNIQUE,
	ano_fundacao int,
	UCI_ID_DiretorDesportivo int NOT NULL,
	FOREIGN KEY (UCI_ID_DiretorDesportivo) REFERENCES DiretorDesportivo(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Localidade (
	latitude varchar(64) NOT NULL,
	longitude varchar(64) NOT NULL,
	altitude varchar(64) NOT NULL,
	nome varchar(64) NOT NULL,
	distrito varchar(64) NOT NULL,
	ordem varchar(64) NOT NULL,
	ID_etapa int NOT NULL,
	PRIMARY KEY(latitude, longitude, altitude),
	FOREIGN KEY (ID_etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Bicicleta (
	codigo int NOT NULL PRIMARY KEY,
	marca varchar(64),
	modelo varchar(64),
	anofabrico int,
	UCI_ID_ciclista int NOT NULL,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

CREATE TABLE ResultadoEtapa (
	tempofinal TIME,
	penalizacaotempo TIME,
	bonificaotempo TIME,
	UCI_ID_ciclista int NOT NULL,
	ID_etapa int NOT NULL,
	ID_classificacao int NOT NULL,
	PRIMARY KEY (UCI_ID_ciclista,ID_etapa),
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_classificacao) REFERENCES Classificacao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);
GO
	
-- RELAÇÕES
CREATE TABLE Pertence (
	data_fim DATE NOT NULL,
	data_inicio DATE NOT NULL,
	ID_equipa int NOT NULL,
	UCI_ID_Ciclista int NOT NULL,
	PRIMARY KEY (ID_equipa, UCI_ID_Ciclista),
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE NO ACTION ON DELETE NO ACTION,
	FOREIGN KEY (ID_equipa) REFERENCES Equipa(ID)
		ON UPDATE NO ACTION ON DELETE NO ACTION
);

CREATE TABLE Patrocina (
	data_fim DATE NOT NULL,
	data_inicio DATE NOT NULL,
	ID_equipa int NOT NULL,
	Nome_patrocinador varchar(64) NOT NULL,
	PRIMARY KEY (ID_equipa, Nome_patrocinador),
	FOREIGN KEY (ID_equipa) REFERENCES Equipa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (Nome_patrocinador) REFERENCES Patrocinador(Nome)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE E_Patrocinado (
	data_fim DATE NOT NULL,
	data_inicio DATE NOT NULL,
	ID_competicao int NOT NULL,
	Nome_patrocinador varchar(64) NOT NULL,
	PRIMARY KEY (ID_competicao, Nome_patrocinador),
	FOREIGN KEY (Nome_patrocinador) REFERENCES Patrocinador(Nome)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competicao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Inclui (
	ID_Etapa int NOT NULL,
	ID_competicao int NOT NULL,
	PRIMARY KEY (ID_etapa, ID_competicao),
	FOREIGN KEY (ID_Etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competicao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Disponibiliza (
	ID_classificacao int NOT NULL,
	ID_competicao int NOT NULL,
	PRIMARY KEY (ID_classificacao, ID_competicao),
	FOREIGN KEY (ID_classificacao) REFERENCES Classificacao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competicao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Participa (
	ID_etapa int NOT NULL,
	UCI_ID_ciclista int NOT NULL,
	PRIMARY KEY (ID_etapa, UCI_ID_ciclista),
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);


GO

-- MultiValor
CREATE TABLE Categoria_Equipa (
	categoria varchar(64) NOT NULL,
	ID_equipa int NOT NULL,
	PRIMARY KEY (categoria, ID_equipa),
	FOREIGN KEY (ID_equipa) REFERENCES Equipa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Categoria_Ciclista (
	categoria varchar(64) NOT NULL,
	UCI_ID_ciclista int NOT NULL,
	PRIMARY KEY (categoria, UCI_ID_ciclista),
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Categoria_Classificacao (
	categoria varchar(64) NOT NULL,
	ID_classificacao int NOT NULL,
	PRIMARY KEY (categoria, ID_classificacao),
	FOREIGN KEY (ID_classificacao) REFERENCES Classificacao(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Camisola_Ciclista (
	camisola varchar(64) NOT NULL,
	UCI_ID_ciclista int NOT NULL,
	PRIMARY KEY (camisola, UCI_ID_ciclista),
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Especificacao_Bicicleta (
	especificacao varchar(64) NOT NULL,
	Codigo_bicicleta int NOT NULL,
	PRIMARY KEY (especificacao, Codigo_bicicleta),
	FOREIGN KEY (Codigo_bicicleta) REFERENCES Bicicleta(Codigo)
		ON UPDATE CASCADE ON DELETE NO ACTION
);


CREATE TABLE Formato_Etapa (
	formato varchar(64) NOT NULL,
	ID_Etapa int NOT NULL,
	PRIMARY KEY (formato, ID_Etapa),
	FOREIGN KEY (ID_Etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

GO

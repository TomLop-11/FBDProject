-- ADICIONAR E EDITAR AS TABELAS E ORDEM

CREATE TABLE Pessoa (
	UCI_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	datanascimento DATE NOT NULL,
	nome varchar(64) NOT NULL,
	nacionalidade varchar(64) NOT NULL,
);
CREATE TABLE Competição (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	organizador varchar(64) NOT NULL,
	nome varchar(64) NOT NULL,
	datainicio DATE NOT NULL,
	datafim DATE NOT NULL,
	n_etapas int NOT NULL,
);
GO

CREATE TABLE DiretorDesportivo (
	UCI_ID int NOT NULL PRIMARY KEY,
	FOREIGN KEY (UCI_ID) REFERENCES Pessoa(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
);
GO
CREATE TABLE Etapa (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	duração TIME NOT NULL,
	numetapa int NOT NULL,
	distância float NOT NULL,
	velocidademedia float NOT NULL,
);
GO

CREATE TABLE Classificação (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	diferençavencedor float NOT NULL,
	posição int NOT NULL
);
GO

CREATE TABLE Equipa (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	paisorigem varchar(64) NOT NULL,
	numciclistas int NOT NULL,
	nome int NOT NULL UNIQUE,
	anofundacao int NOT NULL,
	UCI_ID_DiretorDesportivo int NOT NULL,
	FOREIGN KEY (UCI_ID_DiretorDesportivo) REFERENCES DiretorDesportivo(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
);
GO

CREATE TABLE Ciclista (
	numdorsal int NOT NULL PRIMARY KEY,
	UCI_ID int NOT NULL,
	FOREIGN KEY (UCI_ID) REFERENCES Pessoa(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,

);
CREATE TABLE Patrocinador (
	nome varchar(64) NOT NULL PRIMARY KEY,
	contacto varchar(64) NOT NULL,
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
		ON UPDATE CASCADE ON DELETE NO ACTION,
);
CREATE TABLE Bicicleta (
	codigo int NOT NULL PRIMARY KEY,
	marca varchar(64) NOT NULL,
	modelo varchar(64) NOT NULL,
	anofabrico int NOT NULL,
	numdorsal_ciclista int NOT NULL,
	FOREIGN KEY (numdorsal_ciclista) REFERENCES Ciclista(numdorsal)
		ON UPDATE CASCADE ON DELETE NO ACTION,
);
GO
CREATE TABLE ResultadoEtapa (
	tempofinal TIME NOT NULL PRIMARY KEY,
	penalizacaotempo TIME NOT NULL,
	bonificaotempo TIME NOT NULL,
	numdorsal_ciclista int NOT NULL,
	ID_etapa int NOT NULL,
	ID_classificacao int NOT NULL,
);
GO

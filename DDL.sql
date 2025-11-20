-- ADICIONAR E EDITAR AS TABELAS E ORDEM

-- ENTIDADES
CREATE TABLE Pessoa (
	UCI_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	data_nascimento DATE,
	nome varchar(64) NOT NULL,
	nacionalidade varchar(64) NOT NULL
);
CREATE TABLE Competição (
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
	distancia float NOT NULL,
);
CREATE TABLE Classificação (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	diferenca_vencedor float NOT NULL,
	posicao int NOT NULL
);
GO

CREATE TABLE DiretorDesportivo (
	UCI_ID int NOT NULL PRIMARY KEY,
	FOREIGN KEY (UCI_ID) REFERENCES Pessoa(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
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
	nome int NOT NULL UNIQUE,
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
	tempofinal TIME NOT NULL PRIMARY KEY,
	penalizacaotempo TIME,
	bonificaotempo TIME,
	UCI_ID_ciclista int NOT NULL,
	ID_etapa int NOT NULL,
	ID_classificacao int NOT NULL,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_classificacao) REFERENCES Classificação(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);
GO
	
-- RELAÇÕES
CREATE TABLE Pertence (
	data_fim DATE NOT NULL,
	data_inicio DATE NOT NULL,
	ID_equipa int NOT NULL,
	UCI_ID_Ciclista int NOT NULL,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_equipa) REFERENCES Equipa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Patrocina (
	data_fim DATE NOT NULL,
	data_inicio DATE NOT NULL,
	ID_equipa int NOT NULL,
	Nome_patrocinador varchar(64) NOT NULL,
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
	FOREIGN KEY (Nome_patrocinador) REFERENCES Patrocinador(Nome)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competição(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Inclui (
	ID_Etapa int NOT NULL,
	ID_competicao int NOT NULL,
	FOREIGN KEY (ID_Etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competição(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Disponibiliza (
	ID_classificacao int NOT NULL,
	ID_competicao int NOT NULL,
	FOREIGN KEY (ID_classificacao) REFERENCES Classificação(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_competicao) REFERENCES Competição(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Participa (
	ID_etapa int NOT NULL,
	UCI_ID_Ciclista int NOT NULL,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (ID_etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

-- MultiValor
CREATE TABLE Categoria_Equipa (
	categoria varchar(64) NOT NULL,
	ID_equipa int NOT NULL PRIMARY KEY,
	FOREIGN KEY (ID_equipa) REFERENCES Equipa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Categoria_Ciclista (
	categoria varchar(64),
	UCI_ID_ciclista int NOT NULL PRIMARY KEY,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Categoria_Classificacao (
	categoria varchar(64) NOT NULL,
	ID_classificacao int NOT NULL PRIMARY KEY
	FOREIGN KEY (ID_classificacao) REFERENCES Classificação(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION,
);

CREATE TABLE Camisola_Ciclista (
	camisola varchar(64),
	UCI_ID_ciclista int NOT NULL PRIMARY KEY,
	FOREIGN KEY (UCI_ID_ciclista) REFERENCES Ciclista(UCI_ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Especificacao_Bicicleta (
	especificacao varchar(64) NOT NULL,
	Codigo_bicicleta int NOT NULL PRIMARY KEY,
	FOREIGN KEY (Codigo_bicicleta) REFERENCES Bicicleta(Codigo)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Estado_ResultadoEtapa (
	estado varchar(64),
	tempo_resultadoetapa TIME NOT NULL PRIMARY KEY,
	FOREIGN KEY (tempo_resultadoetapa) REFERENCES ResultadoEtapa(tempo)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE Formato_Etapa (
	formato varchar(64),
	ID_Etapa int NOT NULL PRIMARY KEY,
	FOREIGN KEY (ID_Etapa) REFERENCES Etapa(ID)
		ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

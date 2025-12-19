CREATE SCHEMA Volta_Portugal;
GO

-- Mover tabelas de Entidades Principais
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Pessoa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.DiretorDesportivo;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Equipa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Ciclista;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Bicicleta;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Etapa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Localidade;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.ResultadoEtapa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Classificacao;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Competicao;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Patrocinador;

-- Mover tabelas Atributos Multivalor
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Categoria_Equipa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Categoria_Ciclista;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Especificacao_Bicicleta;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Camisola_Ciclista;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Formato_Etapa;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Categoria_Classificacao;

-- Mover tabelas de Relações
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Orienta;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Pertence;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Patrocina;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.E_Patrocinado;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Disponibiliza;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Inclui;
ALTER SCHEMA Volta_Portugal TRANSFER dbo.Participa;
-- Tabelas que não possuem dependências diretas
DROP TABLE IF EXISTS Volta_Portugal.Formato_Etapa;
DROP TABLE IF EXISTS Volta_Portugal.Especificacao_Bicicleta;
DROP TABLE IF EXISTS Volta_Portugal.Camisola_Ciclista;
DROP TABLE IF EXISTS Volta_Portugal.Categoria_Classificacao;
DROP TABLE IF EXISTS Volta_Portugal.Categoria_Ciclista;
DROP TABLE IF EXISTS Volta_Portugal.Categoria_Equipa;

-- Tabelas de relações
DROP TABLE IF EXISTS Volta_Portugal.Orienta;
DROP TABLE IF EXISTS Volta_Portugal.Participa;
DROP TABLE IF EXISTS Volta_Portugal.Disponibiliza;
DROP TABLE IF EXISTS Volta_Portugal.Inclui;
DROP TABLE IF EXISTS Volta_Portugal.E_Patrocinado;
DROP TABLE IF EXISTS Volta_Portugal.Patrocina;
DROP TABLE IF EXISTS Volta_Portugal.Pertence;

-- Tabelas com dependências de chaves estrangeiras
DROP TABLE IF EXISTS Volta_Portugal.ResultadoEtapa;
DROP TABLE IF EXISTS Volta_Portugal.Bicicleta;
DROP TABLE IF EXISTS Volta_Portugal.Localidade;
DROP TABLE IF EXISTS Volta_Portugal.Equipa;
DROP TABLE IF EXISTS Volta_Portugal.Ciclista;
DROP TABLE IF EXISTS Volta_Portugal.DiretorDesportivo;

-- Tabelas principais
DROP TABLE IF EXISTS Volta_Portugal.Classificacao;
DROP TABLE IF EXISTS Volta_Portugal.Etapa;
DROP TABLE IF EXISTS Volta_Portugal.Patrocinador;
DROP TABLE IF EXISTS Volta_Portugal.Competicao;
DROP TABLE IF EXISTS Volta_Portugal.Pessoa;

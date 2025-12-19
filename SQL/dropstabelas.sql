-- Tabelas que não possuem dependências diretas
DROP TABLE IF EXISTS Estado_ResultadoEtapa;
DROP TABLE IF EXISTS Formato_Etapa;
DROP TABLE IF EXISTS Especificacao_Bicicleta;
DROP TABLE IF EXISTS Camisola_Ciclista;
DROP TABLE IF EXISTS Categoria_Classificacao;
DROP TABLE IF EXISTS Categoria_Ciclista;
DROP TABLE IF EXISTS Categoria_Equipa;

-- Tabelas de relações
DROP TABLE IF EXISTS Participa;
DROP TABLE IF EXISTS Disponibiliza;
DROP TABLE IF EXISTS Inclui;
DROP TABLE IF EXISTS E_Patrocinado;
DROP TABLE IF EXISTS Patrocina;
DROP TABLE IF EXISTS Pertence;

-- Tabelas com dependências de chaves estrangeiras
DROP TABLE IF EXISTS ResultadoEtapa;
DROP TABLE IF EXISTS Bicicleta;
DROP TABLE IF EXISTS Localidade;
DROP TABLE IF EXISTS Equipa;
DROP TABLE IF EXISTS Ciclista;
DROP TABLE IF EXISTS DiretorDesportivo;

-- Tabelas principais
DROP TABLE IF EXISTS Classificacao;
DROP TABLE IF EXISTS Etapa;
DROP TABLE IF EXISTS Patrocinador;
DROP TABLE IF EXISTS Competicao;
DROP TABLE IF EXISTS Pessoa;

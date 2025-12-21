-- Views
-- 1) Lista de todos os ciclistas
GO
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaTodosCiclistas
AS
SELECT 
    P.UCI_ID,
    C.num_dorsal, 
    P.nome AS Nome_Ciclista, 
    P.nacionalidade, 
    P.data_nascimento,
    CC.categoria,
    E.nome AS Nome_Equipa, -- Agora poderá ser NULL
    CAM.camisola AS Tipo_Camisola
FROM Volta_Portugal.Pessoa P
INNER JOIN Volta_Portugal.Ciclista C ON P.UCI_ID = C.UCI_ID
-- Alterado para LEFT JOIN
LEFT JOIN Volta_Portugal.Pertence Per ON C.UCI_ID = Per.UCI_ID_Ciclista
LEFT JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
LEFT JOIN Volta_Portugal.Categoria_Ciclista CC ON C.UCI_ID = CC.UCI_ID_ciclista
LEFT JOIN Volta_Portugal.Camisola_Ciclista CAM ON C.UCI_ID = CAM.UCI_ID_ciclista
GO

-- 2) Lista de todas as equipas

GO
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaEquipas AS
SELECT 
    E.ID, 
    E.nome AS Nome_Equipa, 
    E.pais_origem AS Pais, 
    E.ano_fundacao AS Ano_Fundacao, 
    E.num_ciclistas AS Total_Ciclistas,
    -- Atributo extraído da tabela multi-valor
    CE.categoria AS Categoria
FROM Volta_Portugal.Equipa E
-- Ligação às categorias (LEFT JOIN para incluir equipas que possam ainda não ter categoria)
LEFT JOIN Volta_Portugal.Categoria_Equipa CE ON E.ID = CE.ID_equipa;
GO
-- 3) Lista de todos os diretores desportivos

CREATE OR ALTER VIEW Volta_Portugal.vw_ListaDiretoresDesportivos AS
SELECT 
    P.UCI_ID,
    P.nome AS Nome_Diretor,
    P.nacionalidade AS Nacionalidade,
    P.data_nascimento AS Data_Nascimento,
    E.nome AS Equipa_Atual,
    O.data_inicio AS Inicio_Contrato
FROM Volta_Portugal.Pessoa P
JOIN Volta_Portugal.DiretorDesportivo DD ON P.UCI_ID = DD.UCI_ID
-- Junção com Orienta para obter a relação com a equipa
LEFT JOIN Volta_Portugal.Orienta O ON DD.UCI_ID = O.UCI_ID_DiretorDesportivo 
    AND (O.data_fim > CAST(GETDATE() AS DATE) OR O.data_fim IS NULL)
-- Junção com Equipa para obter o nome da mesma
LEFT JOIN Volta_Portugal.Equipa E ON O.ID_equipa = E.ID;
GO

-- 4) Mostrar o ano e edição de uma competição
CREATE OR ALTER VIEW Volta_Portugal.vw_DetalhesCompeticao AS
SELECT 
    ID,
    nome AS Nome_Original,
    Volta_Portugal.fn_FormatarEdicaoCompeticao(ID) AS Edicao_Formatada,
    organizador
FROM Volta_Portugal.Competicao;

-- 5) View para Marcas
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaBicicletaMarcas AS
SELECT DISTINCT marca 
FROM Volta_Portugal.Bicicleta;
GO

-- 6) View para Modelos
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaBicicletaModelos AS
SELECT DISTINCT modelo 
FROM Volta_Portugal.Bicicleta;
GO



-- Views
GO
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaTodosCiclistas
AS
SELECT 
    P.UCI_ID,
    C.num_dorsal, 
    P.nome AS Nome_Ciclista, 
    P.nacionalidade, 
    P.data_nascimento,
    -- Atributos extraídos das tabelas multi-valor
    CC.categoria,
    E.nome AS Nome_Equipa,
    CAM.camisola AS Tipo_Camisola
FROM Volta_Portugal.Pessoa P
INNER JOIN Volta_Portugal.Ciclista C ON P.UCI_ID = C.UCI_ID
-- Ligação à Equipa através da relação Pertence
INNER JOIN Volta_Portugal.Pertence Per ON C.UCI_ID = Per.UCI_ID_Ciclista
INNER JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
-- Ligação às categorias (LEFT JOIN pois pode ainda não ter categoria atribuída)
LEFT JOIN Volta_Portugal.Categoria_Ciclista CC ON C.UCI_ID = CC.UCI_ID_ciclista
-- Ligação às camisolas (LEFT JOIN pois nem todos os ciclistas têm camisola de líder)
LEFT JOIN Volta_Portugal.Camisola_Ciclista CAM ON C.UCI_ID = CAM.UCI_ID_ciclista
GO
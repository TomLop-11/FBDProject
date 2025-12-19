-- Views
GO
CREATE OR ALTER VIEW Volta_Portugal.vw_ListaTodosCiclistas
AS
SELECT 
    P.UCI_ID,
    C.num_dorsal, 
    P.nome, 
    P.nacionalidade, 
    P.data_nascimento
FROM Volta_Portugal.Pessoa P
JOIN Volta_Portugal.Ciclista C ON P.UCI_ID = C.UCI_ID;
GO
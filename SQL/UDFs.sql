------------------------------------------------------------
-- UDF's
------------------------------------------------------------

CREATE OR ALTER FUNCTION Volta_Portugal.fn_CalcularIdade (@UCI_ID INT)
RETURNS INT
AS
BEGIN
    DECLARE @Idade INT;
    SELECT @Idade = DATEDIFF(YEAR, data_nascimento, GETDATE()) 
    FROM Volta_Portugal.Pessoa 
    WHERE UCI_ID = @UCI_ID;
    RETURN @Idade;
END;
GO
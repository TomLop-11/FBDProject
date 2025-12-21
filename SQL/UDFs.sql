------------------------------------------------------------
-- UDF's
------------------------------------------------------------

-- 1) Calcular idade
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

-- 2) Calcular tempo de diferença do vencedor
CREATE OR ALTER FUNCTION Volta_Portugal.fn_CalcularDiferencaVencedor (@ID_etapa INT, @UCI_ID_ciclista INT)
RETURNS TIME
AS
BEGIN
    DECLARE @TempoCiclistaSegundos INT;
    DECLARE @TempoVencedorSegundos INT;
    DECLARE @DiferencaSegundos INT;
    DECLARE @DiferencaTIME TIME;

    -- 1. Calcular o tempo total do ciclista específico em segundos
    -- Tempo Total = (Tempo Final + Penalização) - Bonificação
    SELECT @TempoCiclistaSegundos = 
        DATEDIFF(SECOND, '00:00:00', tempofinal) + 
        DATEDIFF(SECOND, '00:00:00', ISNULL(penalizacaotempo, '00:00:00')) - 
        DATEDIFF(SECOND, '00:00:00', ISNULL(bonificaotempo, '00:00:00'))
    FROM Volta_Portugal.ResultadoEtapa
    WHERE ID_etapa = @ID_etapa AND UCI_ID_ciclista = @UCI_ID_ciclista;

    -- 2. Calcular o tempo do vencedor (o mínimo tempo total daquela etapa)
    SELECT @TempoVencedorSegundos = MIN(
        DATEDIFF(SECOND, '00:00:00', tempofinal) + 
        DATEDIFF(SECOND, '00:00:00', ISNULL(penalizacaotempo, '00:00:00')) - 
        DATEDIFF(SECOND, '00:00:00', ISNULL(bonificaotempo, '00:00:00'))
    )
    FROM Volta_Portugal.ResultadoEtapa
    WHERE ID_etapa = @ID_etapa;

    -- 3. Calcular a diferença
    SET @DiferencaSegundos = @TempoCiclistaSegundos - @TempoVencedorSegundos;

    -- 4. Converter segundos de volta para o formato TIME
    SET @DiferencaTIME = DATEADD(SECOND, @DiferencaSegundos, '00:00:00');

    RETURN @DiferencaTIME;
END;
GO

-- 3) Formatar o ano e edição com base no id

CREATE OR ALTER FUNCTION Volta_Portugal.fn_FormatarEdicaoCompeticao (@ID_competicao INT)
RETURNS VARCHAR(128)
AS
BEGIN
    DECLARE @Ano INT;
    DECLARE @Edicao INT;
    DECLARE @Resultado VARCHAR(128);

    -- Base de cálculo: ID 1 = 2025 e 86ª Edição
    -- Usamos (ID - 1) para que no ID 1 o incremento seja zero.
    SET @Ano = 2025 + (@ID_competicao - 1);
    SET @Edicao = 86 + (@ID_competicao - 1);

    -- Construção da string de retorno: "86ª Edição (2025)"
    SET @Resultado = CAST(@Edicao AS VARCHAR) + 'ª Edição (' + CAST(@Ano AS VARCHAR) + ')';

    RETURN @Resultado;
END;
GO

-- 4) idade por data
CREATE OR ALTER FUNCTION Volta_Portugal.fn_CalcularIdadePorData (@DataNasc DATE)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @DataNasc, GETDATE());
END;

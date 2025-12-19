------------------------------------------------------------
-- STORED PROCEDURES
------------------------------------------------------------

-- 1) Adicionar Ciclista
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AdicionarCiclista
    @nome VARCHAR(64),
    @nacionalidade VARCHAR(64),
    @data_nascimento DATE,
    @num_dorsal INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Inserir na tabela base Pessoa
        INSERT INTO Volta_Portugal.Pessoa (nome, nacionalidade, data_nascimento)
        VALUES (@nome, @nacionalidade, @data_nascimento);

        DECLARE @NovoID INT = SCOPE_IDENTITY();

        -- Inserir na tabela especializada Ciclista
        INSERT INTO Volta_Portugal.Ciclista (UCI_ID, num_dorsal)
        VALUES (@NovoID, @num_dorsal);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2) Adicionar Diretor Desportivo
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AdicionarDiretor
    @nome VARCHAR(64),
    @nacionalidade VARCHAR(64),
    @data_nascimento DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO Volta_Portugal.Pessoa (nome, nacionalidade, data_nascimento) --
        VALUES (@nome, @nacionalidade, @data_nascimento);

        DECLARE @NovoID INT = SCOPE_IDENTITY();

        INSERT INTO Volta_Portugal.DiretorDesportivo (UCI_ID) --
        VALUES (@NovoID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 3) Associar Ciclista a uma equipa
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AssociarCiclistaEquipa
    @UCI_ID_Ciclista INT,
    @ID_equipa INT,
    @data_inicio DATE,
    @data_fim DATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Volta_Portugal.Pertence (data_inicio, data_fim, ID_equipa, UCI_ID_Ciclista) --
    VALUES (@data_inicio, @data_fim, @ID_equipa, @UCI_ID_Ciclista);
END;
GO

-- 4) Associar Diretor Desportivo a uma equipa
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AssociarDiretorEquipa
    @UCI_ID_Diretor INT,
    @ID_equipa INT,
    @data_inicio DATE,
    @data_fim DATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Volta_Portugal.Orienta (data_inicio, data_fim, ID_equipa, UCI_ID_DiretorDesportivo) --
    VALUES (@data_inicio, @data_fim, @ID_equipa, @UCI_ID_Diretor);
END;
GO

-- 5) Apagar Ciclista
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_ApagarCiclista
    @UCI_ID_Ciclista INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Apagar especificações das bicicletas do ciclista
        DELETE FROM Volta_Portugal.Especificacao_Bicicleta 
        WHERE Codigo_bicicleta IN (SELECT codigo FROM Volta_Portugal.Bicicleta WHERE UCI_ID_ciclista = @UCI_ID_Ciclista);

        -- 2. Apagar as bicicletas
        DELETE FROM Volta_Portugal.Bicicleta WHERE UCI_ID_ciclista = @UCI_ID_Ciclista;

        -- 3. Apagar resultados e participações em etapas
        DELETE FROM Volta_Portugal.ResultadoEtapa WHERE UCI_ID_ciclista = @UCI_ID_Ciclista;
        DELETE FROM Volta_Portugal.Participa WHERE UCI_ID_ciclista = @UCI_ID_Ciclista;

        -- 4. Apagar categorias e camisolas atribuídas
        DELETE FROM Volta_Portugal.Categoria_Ciclista WHERE UCI_ID_ciclista = @UCI_ID_Ciclista;
        DELETE FROM Volta_Portugal.Camisola_Ciclista WHERE UCI_ID_ciclista = @UCI_ID_Ciclista;

        -- 5. Apagar histórico de equipas (Pertence)
        DELETE FROM Volta_Portugal.Pertence WHERE UCI_ID_Ciclista = @UCI_ID_Ciclista;

        -- 6. Apagar da tabela especializada Ciclista
        DELETE FROM Volta_Portugal.Ciclista WHERE UCI_ID = @UCI_ID_Ciclista;

        -- 7. Finalmente, apagar da tabela base Pessoa
        DELETE FROM Volta_Portugal.Pessoa WHERE UCI_ID = @UCI_ID_Ciclista;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 6) Apagar Diretor Desportivo
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_ApagarDiretor
    @UCI_ID_Diretor INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Apagar histórico de orientação de equipas
        DELETE FROM Volta_Portugal.Orienta WHERE UCI_ID_DiretorDesportivo = @UCI_ID_Diretor;

        -- 2. Apagar da tabela especializada DiretorDesportivo
        DELETE FROM Volta_Portugal.DiretorDesportivo WHERE UCI_ID = @UCI_ID_Diretor;

        -- 3. Apagar da tabela base Pessoa
        DELETE FROM Volta_Portugal.Pessoa WHERE UCI_ID = @UCI_ID_Diretor;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
-- 7) Atribuir Bicicleta
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AtribuirBicicleta
    @codigo INT,
    @marca VARCHAR(64),
    @modelo VARCHAR(64),
    @anofabrico INT,
    @UCI_ID_ciclista INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Verifica se o ciclista existe na tabela especializada antes de inserir
    IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Ciclista WHERE UCI_ID = @UCI_ID_ciclista)
    BEGIN
        RAISERROR ('Erro: O UCI_ID fornecido não pertence a um ciclista válido.', 16, 1);
        RETURN;
    END

    -- Insere os dados da bicicleta e a associação ao ciclista
    INSERT INTO Volta_Portugal.Bicicleta (codigo, marca, modelo, anofabrico, UCI_ID_ciclista)
    VALUES (@codigo, @marca, @modelo, @anofabrico, @UCI_ID_ciclista);
    
    PRINT 'Bicicleta atribuída com sucesso ao ciclista.';
END;
GO

-- 8) Remover Bicicleta
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_RemoverBicicleta
    @codigo INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Verificar se a bicicleta existe antes de tentar apagar
        IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Bicicleta WHERE codigo = @codigo) --
        BEGIN
            RAISERROR ('Erro: Não existe nenhuma bicicleta com o código fornecido.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Remover as especificações técnicas da bicicleta primeiro
        DELETE FROM Volta_Portugal.Especificacao_Bicicleta 
        WHERE Codigo_bicicleta = @codigo;

        -- 3. Remover a bicicleta da tabela principal
        DELETE FROM Volta_Portugal.Bicicleta 
        WHERE codigo = @codigo;

        COMMIT TRANSACTION;
        PRINT 'Bicicleta e as suas especificações foram removidas com sucesso.';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 9) Alterar especificações de uma Bicicleta
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AlterarEspecificacaoBicicleta
    @codigoBicicleta INT,
    @especificacaoAntiga VARCHAR(64),
    @especificacaoNova VARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- 1. Verificar se a especificação antiga existe para essa bicicleta
    IF NOT EXISTS (
        SELECT 1 
        FROM Volta_Portugal.Especificacao_Bicicleta 
        WHERE Codigo_bicicleta = @codigoBicicleta AND especificacao = @especificacaoAntiga
    )
    BEGIN
        RAISERROR ('Erro: A especificação antiga não foi encontrada para esta bicicleta.', 16, 1);
        RETURN;
    END

    -- 2. Atualizar para a nova especificação
    UPDATE Volta_Portugal.Especificacao_Bicicleta
    SET especificacao = @especificacaoNova
    WHERE Codigo_bicicleta = @codigoBicicleta AND especificacao = @especificacaoAntiga;

    PRINT 'Especificação atualizada com sucesso.';
END;
GO

-- 10) Adicionar um patrocinador a uma equipa
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AdicionarPatrocinadorEquipa
    @Nome_patrocinador VARCHAR(64),
    @ID_equipa INT,
    @data_inicio DATE,
    @data_fim DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- 1. Verificar se a equipa existe
    IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Equipa WHERE ID = @ID_equipa)
    BEGIN
        RAISERROR ('Erro: A equipa especificada não existe.', 16, 1);
        RETURN;
    END

    -- 2. Verificar se o patrocinador existe
    IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Patrocinador WHERE nome = @Nome_patrocinador)
    BEGIN
        RAISERROR ('Erro: O patrocinador especificado não existe.', 16, 1);
        RETURN;
    END

    -- 3. Inserir a relação de patrocínio
    INSERT INTO Volta_Portugal.Patrocina (data_inicio, data_fim, ID_equipa, Nome_patrocinador)
    VALUES (@data_inicio, @data_fim, @ID_equipa, @Nome_patrocinador);

    PRINT 'Patrocinador associado à equipa com sucesso.';
END;
GO

-- 11) Adicionar um Patrocinador à Competição
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_AdicionarPatrocinadorCompeticao
    @Nome_patrocinador VARCHAR(64),
    @ID_competicao INT,
    @data_inicio DATE,
    @data_fim DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Verificar se a competição existe
    IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Competicao WHERE ID = @ID_competicao)
    BEGIN
        RAISERROR ('Erro: A competição especificada não existe.', 16, 1);
        RETURN;
    END

    -- 2. Verificar se o patrocinador existe
    IF NOT EXISTS (SELECT 1 FROM Volta_Portugal.Patrocinador WHERE nome = @Nome_patrocinador)
    BEGIN
        RAISERROR ('Erro: O patrocinador especificado não existe.', 16, 1);
        RETURN;
    END

    -- 3. Inserir a relação de patrocínio da competição
    INSERT INTO Volta_Portugal.E_Patrocinado (data_inicio, data_fim, ID_competicao, Nome_patrocinador)
    VALUES (@data_inicio, @data_fim, @ID_competicao, @Nome_patrocinador);

    PRINT 'Patrocinador associado à competição com sucesso.';
END;
GO

-- 12) Remover Patrocinador de uma equipa
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_RemoverPatrocinadorEquipa
    @Nome_patrocinador VARCHAR(64),
    @ID_equipa INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Verificar se a associação existe antes de tentar remover
    IF NOT EXISTS (
        SELECT 1 
        FROM Volta_Portugal.Patrocina 
        WHERE ID_equipa = @ID_equipa AND Nome_patrocinador = @Nome_patrocinador
    )
    BEGIN
        RAISERROR ('Erro: Esta associação de patrocínio não existe.', 16, 1);
        RETURN;
    END

    -- 2. Remover a associação
    DELETE FROM Volta_Portugal.Patrocina 
    WHERE ID_equipa = @ID_equipa AND Nome_patrocinador = @Nome_patrocinador;

    PRINT 'Patrocinador removido da equipa com sucesso.';
END;
GO

-- 13) Remover Patrocinador da Competição
CREATE OR ALTER PROCEDURE Volta_Portugal.sp_RemoverPatrocinadorCompeticao
    @Nome_patrocinador VARCHAR(64),
    @ID_competicao INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Verificar se a associação existe
    IF NOT EXISTS (
        SELECT 1 
        FROM Volta_Portugal.E_Patrocinado 
        WHERE ID_competicao = @ID_competicao AND Nome_patrocinador = @Nome_patrocinador
    )
    BEGIN
        RAISERROR ('Erro: Esta associação de patrocínio à competição não existe.', 16, 1);
        RETURN;
    END

    -- 2. Remover a associação
    DELETE FROM Volta_Portugal.E_Patrocinado 
    WHERE ID_competicao = @ID_competicao AND Nome_patrocinador = @Nome_patrocinador;

    PRINT 'Patrocinador removido da competição com sucesso.';
END;
GO
-- 14)
-- 15)
-- 16)
-- 17)
-- 18)
-- 19)
-- 20)
-- 21)
-- 22)
-- 23)
-- 24)
------------------------------------------------------------
-- TRIGGERS
------------------------------------------------------------
-- 1) Atualizar o número de ciclistas de uma equipa
GO
CREATE OR ALTER TRIGGER Volta_Portugal.trg_AtualizarContagemCiclistas
ON Volta_Portugal.Pertence
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Se um ciclista foi ADICIONADO
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE E
        SET E.num_ciclistas = E.num_ciclistas + (SELECT COUNT(*) FROM inserted I WHERE I.ID_equipa = E.ID)
        FROM Volta_Portugal.Equipa E
        JOIN inserted I ON E.ID = I.ID_equipa;
    END

    -- Se um ciclista foi REMOVIDO
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE E
        SET E.num_ciclistas = E.num_ciclistas - (SELECT COUNT(*) FROM deleted D WHERE D.ID_equipa = E.ID)
        FROM Volta_Portugal.Equipa E
        JOIN deleted D ON E.ID = D.ID_equipa;
    END
END;
GO
-- 2) Atualizar o contador de etapas na competição
GO
CREATE OR ALTER TRIGGER Volta_Portugal.trg_AtualizarContagemEtapas
ON Volta_Portugal.Inclui
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Ao adicionar uma etapa à competição
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE C
        SET C.n_etapas = C.n_etapas + 1
        FROM Volta_Portugal.Competicao C
        JOIN inserted I ON C.ID = I.ID_competicao;
    END

    -- Ao remover uma etapa da competição
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE C
        SET C.n_etapas = C.n_etapas - 1
        FROM Volta_Portugal.Competicao C
        JOIN deleted D ON C.ID = D.ID_competicao;
    END
END;
GO

-- 3) Impedir o número de dorsal duplicado
GO
CREATE OR ALTER TRIGGER Volta_Portugal.trg_ValidarDorsalEquipa
ON Volta_Portugal.Pertence
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM Volta_Portugal.Pertence PT
        JOIN Volta_Portugal.Ciclista C1 ON PT.UCI_ID_Ciclista = C1.UCI_ID
        JOIN inserted I ON PT.ID_equipa = I.ID_equipa
        JOIN Volta_Portugal.Ciclista C2 ON I.UCI_ID_Ciclista = C2.UCI_ID
        WHERE PT.UCI_ID_Ciclista <> I.UCI_ID_Ciclista
          AND C1.num_dorsal = C2.num_dorsal -- Dorsais iguais
          AND PT.data_fim >= CAST(GETDATE() AS DATE) -- Contrato ainda ativo
    )
    BEGIN
        RAISERROR ('Erro: Já existe um ciclista com este dorsal nesta equipa.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- 4)
-- 5)
-- 6)
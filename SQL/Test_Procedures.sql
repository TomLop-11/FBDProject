-- Exemplo de teste com parâmetros diretos
EXEC Volta_Portugal.sp_AdicionarCiclista 
    @nome = 'João Silva Teste', 
    @nacionalidade = 'Portugal', 
    @data_nascimento = '1998-05-20', 
    @num_dorsal = 999;
GO
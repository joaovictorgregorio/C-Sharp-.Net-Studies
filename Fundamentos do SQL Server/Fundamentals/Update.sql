SELECT * FROM [Categoria]

-- Muito importante o uso do BEGIN TRANSACTION, pois evita que aconteça perca de dados, caso algum comando seja efetuado de forma errada.
BEGIN TRANSACTION
    -- Update é obrigatório usar com o (WHERE) sempre que for necessário alterar os dados.
    -- Sempre que usar Update, pular uma linha e já adicionar o WHERE para não esquecer o comando.
    UPDATE
        [Categoria]
    SET 
        [Nome] = 'Mobile'
    WHERE
        [Id] = 3
-- Retorna o banco para o padrão anterior, neste caso, antes do UPDATE.
ROLLBACK
-- COMMIT usado para aplicar a alteração.
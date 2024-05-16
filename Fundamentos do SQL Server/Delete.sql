SELECT * FROM [Curso]

-- Quando é feito um DELETE ou UPDATE os dados são modificados permanentemente, não podendo ser mais desfeito.
-- Muito importante fazer um Backup do database, antes de executar esses comandos ou Restore. E usar como padrão BEGIN TRANSACTION e ROLLBACK.
BEGIN TRANSACTION
    DELETE FROM
        [Curso]
    WHERE 
        [CategoriaId] = 3
ROLLBACK
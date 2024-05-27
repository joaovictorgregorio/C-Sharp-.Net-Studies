-- Nunca usar, principalmente em ambiente de trabalho.
SELECT * FROM [Curso]

-- Sempre usar o (TOP 2 ou outra numeração) para trazer apenas os primeiros registros da tabela, evitando possíveis travamentos do banco.
-- E também evitar de usar o (* asterisco) para não matar a performance da busca. Priorizar seguindo as ordens da coluna.
SELECT TOP 100
    [Id], [Nome], [CategoriaId]
FROM 
    [Curso]
-- WHERE 
--     [CategoriaId] = 1
-- Sempre segue a ordenação da esquerda para direita, caso opte por passar mais de uma coluna.
ORDER BY 
    [Nome] DESC
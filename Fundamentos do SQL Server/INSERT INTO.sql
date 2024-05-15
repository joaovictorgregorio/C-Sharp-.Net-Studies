-- Inserindo dados para a coluna [Nome].
INSERT INTO [Categoria]([Nome]) VALUES('Backend')
INSERT INTO [Categoria]([Nome]) VALUES('Frontend')
INSERT INTO [Categoria]([Nome]) VALUES('Mobile')

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos do C#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Angular', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Flutter', 3)

-- Inserindo dados de forma direta, sem referenciar a coluna, apenas seguindo a ordem ordenada das colunas. Priorizar o formato referenciando os nomes.
INSERT INTO [Curso] VALUES('Flutter e SQLIte', 3)

SELECT * FROM [Categoria]
SELECT * FROM [Curso]
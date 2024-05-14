USE [Curso] -- Garante que eu faça as alterações no Banco de Dados correto que realmente precise modificar.

DROP TABLE [Aluno]
CREATE TABLE [Aluno] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL, -- DEFAULT sempre entra com algum valor padrão, neste caso, a data atual
    [Active] BIT NOT NULL DEFAULT(0) -- DEFAULT sempre entra com algum valor padrão, neste caso, valor 0

    -- PRIMARY KEY significa que o valor não pode ser nulo e ele é único, podendo até remover o NOT NULL a frente do tipo de dado
    -- CONSTRAINT renomea a nomenclatura de identificação da chave
    CONSTRAINT [PK_Aluno_Id] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email])
)
GO -- Insere as informações automaticamente no banco de dados

-- Dropando uma chave
-- ALTER TABLE [Aluno]
--     DROP CONSTRAINT [PK_Aluno_Id]

-- Adicionado uma coluna a tabela
-- ALTER TABLE [Aluno] 
--     ADD [Documento] NVARCHAR (11)

-- Removendo uma coluna da tabela
-- ALTER TABLE [Aluno]
--     DROP COLUMN [Documento]

-- Alterando o tipo de dado da coluna
-- ALTER TABLE [Aluno]
--     ALTER COLUMN [Documento] CHAR(11)
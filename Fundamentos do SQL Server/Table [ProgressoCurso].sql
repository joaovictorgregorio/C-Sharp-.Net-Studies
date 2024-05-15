USE [Curso]

DROP TABLE [ProgressoCurso]

CREATE TABLE [ProgressoCurso] (
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT [PK_ProgressoCurso] PRIMARY KEY([AlunoId], [CursoId])
)
GO
USE [Blog]
GO

CREATE TABLE [PostTag] (
    [PostId] INT NOT NULL,
    [TagId] INT NOT NULL

    CONSTRAINT PK_PostTag PRIMARY KEY([PostId], [TagId])
)
CREATE DATABASE [balta]

USE [balta]
CREATE TABLE [Student] 
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Name] NVARCHAR(120) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Document] NVARCHAR(20) NULL,
    [Phone] NVARCHAR(20) NULL,
    [Birthdate] DATETIME NULL,
    [CreateDate] DATETIME NOT NULL DEFAULT(DATEADD(HOUR, -3, GETUTCDATE())),

    CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
);
GO

USE [balta]
CREATE TABLE [Author] 
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Name] NVARCHAR(80) NOT NULL,
    [Title] NVARCHAR(80) NOT NULL,
    [Image] NVARCHAR(1024) NULL,
    [Bio] NVARCHAR(2000) NULL,
    [Url] NVARCHAR(450) NULL,
    [Email] NVARCHAR(160) NOT NULL,
    [Type] TINYINT NOT NULL, -- 0 a 255

    CONSTRAINT [PK_Author] PRIMARY KEY ([Id])
);
GO

USE [balta]
CREATE TABLE [Career] 
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Title] NVARCHAR(160) NOT NULL,
    [Summary] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(450) NULL,
    [DurationInMinutes] INT NOT NULL,
    [Active] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,

    CONSTRAINT [PK_Career] PRIMARY KEY ([Id])
);
GO

USE [balta]
CREATE TABLE [Category] 
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Title] NVARCHAR(160) NOT NULL,
    [Url] NVARCHAR(450) NULL,
    [Summary] NVARCHAR(2000) NOT NULL,
    [Order] INT NOT NULL,
    [Description] TEXT NOT NULL,
    [Featured] BIT NOT NULL,

    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);
GO

USE [balta]
CREATE TABLE [Course] 
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Tag] NVARCHAR(20) NOT NULL,
    [Title] NVARCHAR(160) NULL,
    [Summary] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [Level] TINYINT NOT NULL,
    [DurationInMinutes] INT NOT NULL,
    [CreateDate] DATETIME NOT NULL,
    [LastUpdateDate] DATETIME NOT NULL,
    [Active] BIT NOT NULL,
    [Free] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [AuthorId] UNIQUEIDENTIFIER NOT NULL,
    [CategoryId] UNIQUEIDENTIFIER NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,

    CONSTRAINT [PK_Course] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Course_Author_AuthorId] FOREIGN KEY ([AuthorId])
        REFERENCES [Author] ([Id]),
    CONSTRAINT [PK_Course_Category_CategoryId] FOREIGN KEY ([CategoryId])
        REFERENCES [Category] ([Id])
);
GO

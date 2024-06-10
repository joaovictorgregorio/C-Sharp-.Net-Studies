USE [Blog]
GO

CREATE TABLE [UserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL

    CONSTRAINT [PK_UserRole] PRIMARY KEY([UserId], [RoleId])
)
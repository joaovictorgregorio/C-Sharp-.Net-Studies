CREATE OR ALTER VIEW vwCourses AS
    SELECT 
        [C].[Id],
        [C].[Tag],
        [C].[Title],
        [C].[Url],
        [C].[Summary],
        [C].[CreateDate],
        [Category].[Title] AS [Category],
        [A].[Name] AS [Author]
    FROM 
        [Course] C
    INNER JOIN 
        [Category] ON [C].[CategoryId] = [Category].[Id]
    INNER JOIN
        [Author] A ON [C].[AuthorId] = [A].[Id]
    WHERE
        [Active] = 1
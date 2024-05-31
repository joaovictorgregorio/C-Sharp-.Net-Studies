SELECT * FROM [Course]


SELECT * FROM [Student]
DECLARE @studentId UNIQUEIDENTIFIER = (SELECT NEWID())

INSERT INTO 
    [Student] ([Id], [Name], [Email], [Document], [Phone], [Birthdate], [CreateDate])
VALUES ( 
    @studentId,
    'Joao Victor Gregorio',
    'joaovictor@gmail.com',
    '12345678910',
    '17999887766',
    NULL,
    DATEADD(HOUR, -3, GETUTCDATE())
)


SELECT * FROM [StudentCourse]

INSERT INTO 
    [StudentCourse] ([CourseId], [StudentId], [Progress], [Favorite], [StartDate], [LastUpdateDate])
VALUES (
    '5f5a33f8-4ff3-7e10-cc6e-3fa000000001',
    'b99bbea5-d273-45f3-b73e-78a230a25959',
    50,
    0,
    '2024-02-01 09:45:23',
    DATEADD(HOUR, -3, GETUTCDATE())
)
CREATE TABLE [dbo].[Ratings]
(
    [PostId] INT NOT NULL, 
    [UserId] NVARCHAR(256) NOT NULL,
    [Rating] BIT NULL, 
    PRIMARY KEY ([PostId], [UserId])  
)

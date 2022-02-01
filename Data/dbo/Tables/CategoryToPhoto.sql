CREATE TABLE [dbo].[CategoryToPhoto]
(
	[PhotoId] INT NOT NULL, 
    [CategoryId] INT NOT NULL,
	CONSTRAINT PK_CategoryToPhoto PRIMARY KEY ([PhotoId], [CategoryId])
)

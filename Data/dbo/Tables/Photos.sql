CREATE TABLE [dbo].[Photos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NOT NULL, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Photo] NVARCHAR(250) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Location] NVARCHAR(100) NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LocationLongitude] FLOAT NULL, 
    [LocationLatitude] FLOAT NULL, 
    [LocationAltitude] FLOAT NULL
)

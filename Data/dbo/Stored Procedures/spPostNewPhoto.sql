CREATE PROCEDURE [dbo].[spPostNewPhoto]
	@Photo nvarchar(100),
	@Title NVARCHAR(100),
	@Description nvarchar(MAX),
	@Location NVARCHAR(100)

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO Photos(Title, Photo, Description, Location) 
	VALUES (@Title,@Photo,@Description,@Location)
END

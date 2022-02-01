CREATE PROCEDURE [dbo].[spAddCategoryToPhoto]
	@PhotoId int,
	@Category nvarchar(256)
AS
	SET NOCOUNT ON
	DECLARE @CategoryId INT
	SELECT @CategoryId = Id FROM Category WHERE Title = @Category
	INSERT INTO CategoryToPhoto (PhotoId, CategoryId) VALUES (@PhotoId, @CategoryId)
RETURN 0

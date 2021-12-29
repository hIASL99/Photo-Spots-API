CREATE PROCEDURE [dbo].[spDeletePhoto]
	@id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE
	FROM Photos
	WHERE Id = @id
END

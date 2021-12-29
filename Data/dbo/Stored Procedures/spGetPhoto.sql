CREATE PROCEDURE [dbo].[spGetPhoto]
	@id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM Photos
	WHERE Id = @id
END

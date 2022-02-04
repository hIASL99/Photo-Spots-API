CREATE PROCEDURE [dbo].[spChangePhoto]
	@Id int,
	@Title NVARCHAR(100),
	@Description nvarchar(MAX),
	@Location NVARCHAR(100)

AS
BEGIN
	SET NOCOUNT ON
	UPDATE Photos
	SET Title = @Title, Description = @Description
	WHERE Id = @Id;
END

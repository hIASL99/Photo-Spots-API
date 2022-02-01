CREATE PROCEDURE [dbo].[spGetCatgeoriesForPost]
	@PostId int
AS
	SET NOCOUNT ON
	SELECT c.Id, c.Title FROM Category c INNER JOIN CategoryToPhoto ctp ON ctp.CategoryId = c.Id WHERE ctp.PhotoId = @PostId 
RETURN 0

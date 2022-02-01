CREATE PROCEDURE [dbo].[spGetCommentForPost]
	@PostId int
AS
	SELECT u.UserName as UserName, c.Text as Text FROM Comment c INNER JOIN AspNetUsers u ON u.Id = c.UserId WHERE PostId = @PostId
RETURN 0

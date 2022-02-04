CREATE PROCEDURE [dbo].[spGetCommentForPost]
	@PostId int
AS
	SELECT u.UserName as UserName, c.Text as Text, FORMAT (c.Date, 'dd-MM-yyyy hh:mm') as DatePosted FROM Comment c INNER JOIN AspNetUsers u ON u.Id = c.UserId WHERE PostId = @PostId ORDER BY c.Date DESC
RETURN 0

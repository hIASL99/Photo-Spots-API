CREATE PROCEDURE [dbo].[spDeleteRating]
	@UserId nvarchar(256),
	@PostId int
AS
	SET NOCOUNT ON
	DELETE FROM Ratings WHERE UserId = @UserId AND PostId = @PostId
RETURN 0

CREATE PROCEDURE [dbo].[spAddComment]
	@PostId int,
	@Text nvarchar(MAX),
	@UserId nvarchar(256)
AS
	INSERT INTO Comment (PostId, [Text], UserId) VALUES (@PostId, @Text, @UserId)
RETURN

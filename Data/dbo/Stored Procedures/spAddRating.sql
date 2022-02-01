CREATE PROCEDURE [dbo].[spAddRating]
	@UserId nvarchar(256),
	@PostId int,
	@Rating bit
AS
	SET NOCOUNT ON
	IF ((SELECT COUNT(*) FROM dbo.Ratings WHERE PostId = @PostId AND UserId = @UserId) = 0)
		BEGIN
			INSERT INTO Ratings (PostId, UserId, Rating) VALUES (@PostId, @UserId, @Rating)
		END
	ELSE
		BEGIN
			UPDATE Ratings SET Rating = @Rating WHERE PostId = @PostId AND UserId = @UserId
		END
RETURN 0

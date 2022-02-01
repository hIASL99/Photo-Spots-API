CREATE PROCEDURE [dbo].[spGetAllRatingsForPost]
	@Id int
AS
	SET NOCOUNT ON
	SELECT u.UserName as UserId, r.Rating FROM Ratings r INNER JOIN AspNetUsers u ON u.Id = r.UserId WHERE r.PostId = @Id
RETURN 0

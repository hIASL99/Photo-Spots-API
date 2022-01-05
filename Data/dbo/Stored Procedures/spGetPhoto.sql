CREATE PROCEDURE [dbo].[spGetPhoto]
	@id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT p.Id, p.UserId, p.Title, p.Photo, p.[Description], p.[Location], p.LocationLongitude, p.LocationLatitude, p.LocationAltitude, u.[UserName] AS UserName
	FROM Photos p
	INNER JOIN AspNetUsers u ON u.Id = p.UserId
	WHERE p.Id = @id
END

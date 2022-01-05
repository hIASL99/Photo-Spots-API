CREATE PROCEDURE [dbo].[spPostNewPhoto]
	@UserId nvarchar(128),
	@Photo nvarchar(250),
	@Title NVARCHAR(100),
	@Description nvarchar(MAX),
	@Location NVARCHAR(100),
	@LocationLongitude FLOAT,
	@LocationLatitude FLOAT,
	@LocationAltitude FLOAT
	

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO Photos(UserId, Title, Photo, Description, Location, LocationLongitude, LocationLatitude, LocationAltitude) 
	VALUES (@UserId, @Title,@Photo,@Description,@Location,@LocationLongitude,@LocationLatitude,@LocationAltitude)
END

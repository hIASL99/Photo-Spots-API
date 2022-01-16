CREATE PROCEDURE [dbo].[spUpdateUsername]
	@UserName nvarchar(256),
	@Id nvarchar(128)
AS
	Update AspNetUsers Set UserName = @UserName WHERE Id = @Id 
RETURN 0

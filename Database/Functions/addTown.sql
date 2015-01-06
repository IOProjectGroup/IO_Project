CREATE PROCEDURE [dbo].[AddTown]
	@nazwa nvarchar(50)
AS
	INSERT INTO [dbo].[Miasta] (nazwa)
	values (lower(@nazwa));
RETURN 0

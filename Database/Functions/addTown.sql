CREATE PROCEDURE [dbo].[AddTown]
	@nazwa varchar(50)
AS
	INSERT INTO [dbo].[Miasta] (nazwa)
	values (@nazwa);
RETURN 0

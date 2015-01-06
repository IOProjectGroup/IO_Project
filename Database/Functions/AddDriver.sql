CREATE PROCEDURE [dbo].[AddDriver]
	@imie nvarchar(50),
	@nazwisko nvarchar(50),
	@pesel varchar(11)
AS
	INSERT INTO [dbo].[Kierowcy] (imie,nazwisko,pesel)
	VALUES (lower(@imie),lower(@nazwisko),@pesel)
RETURN 0

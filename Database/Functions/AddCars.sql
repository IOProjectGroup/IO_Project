CREATE PROCEDURE [dbo].[AddCars]
	@marka varchar(10),
	@model varchar(15),
	@koszt_zakupu money,
	@rok_produkcji date,
	@rok_zakupu date,
	@nr_rejestracyjny varchar(10)
AS
	SET NOCOUNT OFF;
	INSERT INTO [dbo].[Samochody] (marka, model, koszt_zakupu, rok_produkcji, rok_zakupu, nr_rejestracyjny) 
	VALUES (@marka, @model, @koszt_zakupu, @rok_produkcji, @rok_zakupu, @nr_rejestracyjny);
RETURN 0

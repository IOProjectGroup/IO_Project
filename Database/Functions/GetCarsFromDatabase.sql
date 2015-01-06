CREATE PROCEDURE [dbo].[GetCarsFromDatabase]
AS
	SELECT marka, model, koszt_zakupu, rok_produkcji, rok_zakupu, nr_rejestracyjny from Samochody
RETURN 0

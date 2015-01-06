CREATE PROCEDURE [dbo].[AddRoute]
	@nr_rejestracyjny varchar(10),
	@pesel varchar(11),
	@stan_licznika_przed float,
	@stan_licznika_po float,
	@miasto_poczatkowe nvarchar(50),
	@miasto_koncowe nvarchar(50)
AS
	DECLARE @err_message nvarchar(255)
	DECLARE @ID_route int
	SET NOCOUNT OFF;

	IF NOT EXISTS (SELECT nazwa FROM Miasta WHERE Miasta.nazwa = lower(@miasto_poczatkowe))
		EXEC AddTown @miasto_poczatkowe
	IF NOT EXISTS (SELECT nazwa FROM Miasta WHERE Miasta.nazwa = lower(@miasto_koncowe))
		EXEC AddTown @miasto_koncowe

	IF NOT EXISTS (SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = upper(@nr_rejestracyjny))
		BEGIN
			 SET @err_message =  + 'Samochód o numerze rejestracyjnym ' + upper(@nr_rejestracyjny) + ' nie istnieje w bazie'
             RAISERROR (@err_message, 16, 1) 
		END
	ELSE IF NOT EXISTS (SELECT ID_kierowcy from Kierowcy where Kierowcy.pesel = @pesel)
		BEGIN
			 SET @err_message =  + 'Kierowca o numerze pesel ' + @pesel + ' nie istnieje w bazie'
             RAISERROR (@err_message, 16, 1) 
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Trasy](ID_kierowcy,ID_samochodu,stan_licznika_przed, stan_licznika_po) 
			VALUES ((SELECT ID_kierowcy from Kierowcy where Kierowcy.pesel = @pesel),
					(SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = upper(@nr_rejestracyjny)),
					@stan_licznika_przed,@stan_licznika_po)

			SET @ID_route = (SELECT SCOPE_IDENTITY())

			INSERT INTO [dbo].[Trasy_Miasta](ID_miasta,ID_trasy)
			VALUES ((SELECT ID_miasta FROM Miasta WHERE Miasta.nazwa = lower(@miasto_poczatkowe)),@ID_route)

			INSERT INTO [dbo].[Trasy_Miasta](ID_miasta,ID_trasy)
			VALUES ((SELECT ID_miasta FROM Miasta WHERE Miasta.nazwa = lower(@miasto_koncowe)),@ID_route)
		END
RETURN 0
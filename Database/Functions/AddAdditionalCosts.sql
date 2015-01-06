CREATE PROCEDURE [dbo].[AddAdditionalCosts]
	@nr_rejestracyjny varchar(10),
	@pesel varchar(11),
	@koszt_dodatkowy money,
	@opis varchar(MAX)
AS
	DECLARE @err_message nvarchar(255)
	SET NOCOUNT OFF;
	IF NOT EXISTS (SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = @nr_rejestracyjny)
		BEGIN
			 SET @err_message =  + 'Samochód o numerze rejestracyjnym ' + @nr_rejestracyjny + ' nie istnieje w bazie'
             RAISERROR (@err_message, 16, 1) 
		END
	ELSE IF NOT EXISTS (SELECT ID_kierowcy from Kierowcy where Kierowcy.pesel = @pesel)
		BEGIN
			 SET @err_message =  + 'Kierowca o numerze pesel ' + @pesel + ' nie istnieje w bazie'
             RAISERROR (@err_message, 16, 1) 
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Dodatkowe_koszty](ID_kierowcy,ID_samochodu,koszt_dodatkowy,opis) 
			VALUES ((SELECT ID_kierowcy from Kierowcy where Kierowcy.pesel = @pesel),
					(SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = @nr_rejestracyjny),
					@koszt_dodatkowy,@opis)
		END
RETURN 0

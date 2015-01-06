CREATE PROCEDURE [dbo].[AddInsurance]
	@nr_rejestracyjny varchar(10),
	@koszt money,
	@data_zakupu date,
	@data_waznosci date
AS
	DECLARE @err_message nvarchar(255)
	SET NOCOUNT OFF;
	IF NOT EXISTS (SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = upper(@nr_rejestracyjny))
		BEGIN
			 SET @err_message =  + 'Samochód o numerze rejestracyjnym ' + upper(@nr_rejestracyjny) + ' nie istnieje w bazie'
             RAISERROR (@err_message, 16, 1) 
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Ubezpieczenia](ID_samochodu,koszt,data_zakupu,data_waznosci) 
			VALUES ((SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = upper(@nr_rejestracyjny)),@koszt,@data_zakupu,@data_waznosci)
		END
RETURN 0
﻿CREATE PROCEDURE [dbo].[AddRepairs]
	@nr_rejestracyjny varchar(10),
	@koszt money,
	@data_naprawy date,
	@opis nvarchar(MAX)
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
			INSERT INTO [dbo].[Naprawy](ID_samochodu,koszt,data_naprawy,opis) 
			VALUES ((SELECT ID_samochodu from Samochody where Samochody.nr_rejestracyjny = upper(@nr_rejestracyjny)),@koszt,@data_naprawy,@opis)
		END
RETURN 0

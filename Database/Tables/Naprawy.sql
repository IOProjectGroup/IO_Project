CREATE TABLE [dbo].[Naprawy]
(
	[ID_naprawy] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_samochodu] INT NOT NULL, 
    [koszt] MONEY NOT NULL, 
    [data_naprawy] DATE NOT NULL, 
    [opis] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [Naprawy_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

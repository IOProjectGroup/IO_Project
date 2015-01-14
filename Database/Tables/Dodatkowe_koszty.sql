CREATE TABLE [dbo].[Dodatkowe_koszty]
(
	[ID_kosztu] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_kierowcy] INT NOT NULL, 
    [ID_samochodu] INT NOT NULL, 
    [koszt_dodatkowy] MONEY NOT NULL, 
    [opis] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [Dod_koszty_ID_kierowcy] FOREIGN KEY ([ID_kierowcy]) REFERENCES [Kierowcy]([ID_kierowcy]), 
    CONSTRAINT [Dod_koszty_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

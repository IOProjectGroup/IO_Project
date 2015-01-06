CREATE TABLE [dbo].[Trasy]
(
	[ID_trasy] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_kierowcy] INT NOT NULL, 
    [ID_samochodu] INT NOT NULL, 
    [stan_licznika_przed] FLOAT NULL, 
    [stan_licznika_po] FLOAT NULL
	CONSTRAINT [Trasy_ID_kierowcy] FOREIGN KEY ([ID_kierowcy]) REFERENCES [Kierowcy]([ID_kierowcy]), 
    CONSTRAINT [Trasy_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

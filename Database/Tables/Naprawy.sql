CREATE TABLE [dbo].[Table2]
(
	[ID_naprawy] INT NOT NULL PRIMARY KEY, 
    [ID_samochodu] INT NOT NULL, 
    [koszt] MONEY NULL, 
    [data_naprawy] DATE NULL, 
    [opis] VARCHAR(MAX) NULL, 
    CONSTRAINT [Naprawy_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

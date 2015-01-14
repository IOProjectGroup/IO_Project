CREATE TABLE [dbo].[Tankowania]
(
	[ID_tankowania] INT NOT NULL PRIMARY KEY IDENTITY, 
    [koszt] MONEY NOT NULL, 
    [paliwo] FLOAT NOT NULL, 
    [ID_samochodu] INT NOT NULL, 
    CONSTRAINT [Tankowania_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu]) 
)

GO

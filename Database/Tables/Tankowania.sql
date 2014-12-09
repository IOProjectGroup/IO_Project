CREATE TABLE [dbo].[Tankowania]
(
	[ID_tankowania] INT NOT NULL PRIMARY KEY, 
    [koszt] MONEY NULL, 
    [paliwo] FLOAT NULL, 
    [ID_samochodu] INT NOT NULL, 
    CONSTRAINT [Tankowania_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu]) 
)

GO

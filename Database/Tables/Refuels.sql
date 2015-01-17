CREATE TABLE [dbo].[Refuels]
(
	[ID_refuel] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_car] INT NOT NULL, 
	[Cost] MONEY NOT NULL, 
    [Fuel] FLOAT NOT NULL, 
    CONSTRAINT [FK_Refuels_ID_car] FOREIGN KEY ([ID_car]) REFERENCES [Cars]([ID_car]) 
)

GO

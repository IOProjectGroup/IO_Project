CREATE TABLE [dbo].[AdditionalCosts]
(
	[ID_cost] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_driver] INT NOT NULL, 
    [ID_car] INT NOT NULL, 
    [Cost] MONEY NOT NULL, 
    [Specification] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_AdditionalCosts_ID_driver] FOREIGN KEY ([ID_driver]) REFERENCES [Drivers]([ID_driver]), 
    CONSTRAINT [FK_AdditionalCosts_ID_car] FOREIGN KEY ([ID_car]) REFERENCES [Cars]([ID_car])
)

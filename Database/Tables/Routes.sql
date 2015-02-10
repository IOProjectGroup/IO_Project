CREATE TABLE [dbo].[Routes]
(
	[ID_route] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_driver] INT NOT NULL, 
    [ID_car] INT NOT NULL, 
    [MileageCounterStart] FLOAT NOT NULL, 
    [MileageCounterEnd] FLOAT NOT NULL
	CONSTRAINT [FK_Routes_ID_driver] FOREIGN KEY ([ID_driver]) REFERENCES [Drivers]([ID_driver]), 
    CONSTRAINT [FK_Routes_ID_car] FOREIGN KEY ([ID_car]) REFERENCES [Cars]([ID_car])
)

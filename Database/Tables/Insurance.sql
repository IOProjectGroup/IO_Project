CREATE TABLE [dbo].[Insurance]
(
	[ID_insurance] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_car] INT NOT NULL, 
    [DateOfPurchase] DATE NOT NULL, 
    [DateOfExpiry] DATE NOT NULL, 
    [Cost] MONEY NOT NULL, 
    CONSTRAINT [FK_Insurance_ID_car] FOREIGN KEY ([ID_car]) REFERENCES [Cars]([ID_car])
)

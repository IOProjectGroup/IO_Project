CREATE TABLE [dbo].[Cars]
(
	[ID_car] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Brand] VARCHAR(10) NOT NULL, 
    [Model] VARCHAR(15) NOT NULL, 
    [Cost] MONEY NOT NULL, 
    [DateOfProduction] DATE NOT NULL, 
    [DateOfPurchase] DATE NOT NULL, 
    [RegistrationNumber] VARCHAR(10) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Cars_regNumber] ON [dbo].[Cars] ([RegistrationNumber])

CREATE TABLE [dbo].[Repairs]
(
	[ID_repair] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_car] INT NOT NULL, 
    [Cost] MONEY NOT NULL, 
    [DateOfRepair] DATE NOT NULL, 
    [Specification] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Repairs_ID_car] FOREIGN KEY ([ID_car]) REFERENCES [Cars]([ID_car])
)

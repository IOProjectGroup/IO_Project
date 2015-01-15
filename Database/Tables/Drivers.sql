CREATE TABLE [dbo].[Drivers]
(
	[ID_driver] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Pesel] VARCHAR(11) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Drivers_pesel] ON [dbo].[Drivers] ([Pesel])

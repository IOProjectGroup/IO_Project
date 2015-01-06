CREATE TABLE [dbo].[Kierowcy]
(
	[ID_kierowcy] INT NOT NULL PRIMARY KEY IDENTITY, 
    [imie] NVARCHAR(50) NOT NULL, 
    [nazwisko] NVARCHAR(50) NOT NULL, 
    [pesel] VARCHAR(11) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Kierowcy_pesel] ON [dbo].[Kierowcy] ([pesel])

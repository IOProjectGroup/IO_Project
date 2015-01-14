CREATE TABLE [dbo].[Samochody]
(
	[ID_samochodu] INT NOT NULL PRIMARY KEY IDENTITY, 
    [marka] VARCHAR(10) NOT NULL, 
    [model] VARCHAR(15) NOT NULL, 
    [koszt_zakupu] MONEY NOT NULL, 
    [rok_produkcji] DATE NOT NULL, 
    [rok_zakupu] DATE NOT NULL, 
    [nr_rejestracyjny] VARCHAR(10) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Samochody_nr_rejestracyjny] ON [dbo].[Samochody] ([nr_rejestracyjny])

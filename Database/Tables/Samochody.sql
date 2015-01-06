CREATE TABLE [dbo].[Samochody]
(
	[ID_samochodu] INT NOT NULL PRIMARY KEY IDENTITY, 
    [marka] VARCHAR(10) NULL, 
    [model] VARCHAR(15) NULL, 
    [koszt_zakupu] MONEY NULL, 
    [rok_produkcji] DATE NULL, 
    [rok_zakupu] DATE NULL, 
    [nr_rejestracyjny] VARCHAR(10) NULL
)

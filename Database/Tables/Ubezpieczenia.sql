CREATE TABLE [dbo].[Ubezpieczenia]
(
	[ID_ubezpieczenia] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_samochodu] INT NOT NULL, 
    [data_zakupu] DATE NULL, 
    [data_waznosci] DATE NULL, 
    [koszt] MONEY NULL, 
    CONSTRAINT [Ubezpieczenia_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

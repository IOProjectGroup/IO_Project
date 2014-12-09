CREATE TABLE [dbo].[Table1]
(
	[ID_ubezpieczenia] INT NOT NULL PRIMARY KEY, 
    [ID_samochodu] INT NOT NULL, 
    [data_zakupu] DATE NULL, 
    [data_waznosci] DATE NULL, 
    [koszt] MONEY NULL, 
    CONSTRAINT [Ubezpieczenia_ID_samochodu] FOREIGN KEY ([ID_samochodu]) REFERENCES [Samochody]([ID_samochodu])
)

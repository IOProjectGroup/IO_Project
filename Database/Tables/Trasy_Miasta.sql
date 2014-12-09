CREATE TABLE [dbo].[Trasy_Miasta]
(
	[ID_trasy] INT NOT NULL, 
    [ID_miasta] INT NOT NULL, 
    CONSTRAINT [Trasy_Miasta_ID_trasy] FOREIGN KEY ([ID_trasy]) REFERENCES [Trasy]([ID_trasy]), 
    CONSTRAINT [Trasy_Miasta_ID_miasta] FOREIGN KEY ([ID_miasta]) REFERENCES [Miasta]([ID_miasta]) 
)

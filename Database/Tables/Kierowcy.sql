﻿CREATE TABLE [dbo].[Kierowcy]
(
	[ID_kierowcy] INT NOT NULL PRIMARY KEY IDENTITY, 
    [imie] VARCHAR(50) NULL, 
    [nazwisko] VARCHAR(50) NULL, 
    [pesel] VARCHAR(11) NULL
)

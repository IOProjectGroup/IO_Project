CREATE TABLE [dbo].[RoutesToTowns]
(
	[ID_route] INT NOT NULL, 
    [ID_town] INT NOT NULL, 
    CONSTRAINT [FK_RoutesToTowns_ID_trasy] FOREIGN KEY ([ID_route]) REFERENCES [Routes]([ID_route]), 
    CONSTRAINT [FK_RoutesToTowns_ID_miasta] FOREIGN KEY ([ID_town]) REFERENCES [Towns]([ID_town]) 
)

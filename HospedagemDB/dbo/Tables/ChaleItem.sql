CREATE TABLE [dbo].[ChaleItem]
(
	[ChaleId] INT NOT NULL,
    [ItemId] INT NOT NULL,

    CONSTRAINT [PK_ChaleItem] PRIMARY KEY ([ChaleId],[ItemId])
)

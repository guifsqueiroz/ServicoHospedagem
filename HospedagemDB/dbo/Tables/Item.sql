CREATE TABLE [dbo].[Item] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (50) NOT NULL,
    [Descricao] TEXT          NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Item_Nome]
    ON [dbo].[Item]([Nome] ASC);


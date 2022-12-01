CREATE TABLE [dbo].[Chale] (
    [Id]                INT			   IDENTITY (1, 1)NOT NULL,
    [Localizacao]       NVARCHAR (300) NOT NULL,
    [Capacidade]        TINYINT        NOT NULL,
    [ValorAltaEstacao]  INT            NOT NULL,
    [ValorBaixaEstacao] INT            NOT NULL,
    CONSTRAINT [PK_Chale] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE NONCLUSTERED INDEX [IX_Chale_Capacidade]
    ON [dbo].[Chale]([Capacidade] ASC);


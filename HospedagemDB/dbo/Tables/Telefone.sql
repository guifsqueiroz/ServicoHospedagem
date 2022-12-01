CREATE TABLE [dbo].[Telefone] (
    [Numero]       NVARCHAR (20) NOT NULL,
    [ClienteId]    INT           NOT NULL,
    [TipoTelefone] VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_Telefone] PRIMARY KEY CLUSTERED ([Numero]),
    CONSTRAINT [FK_Telefone_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Cliente] ([Id])
);
GO

CREATE TABLE [dbo].[Servico] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (30) NOT NULL,
    [Valor] INT          NOT NULL,
    CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED ([Id] ASC)
);


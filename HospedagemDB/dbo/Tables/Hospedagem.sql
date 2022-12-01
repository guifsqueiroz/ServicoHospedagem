CREATE TABLE [dbo].[Hospedagem]
(
	[Id] INT NOT NULL,
    [ChaleId] INT NOT NULL,
    [ClienteId] INT NOT NULL,
    [Estado] BIT NOT NULL,
    [DataInicio] DATETIME NOT NULL DEFAULT(GETDATE()),
    [DataFim]   DATETIME NOT NULL DEFAULT(GETDATE()), 
    [QtdPessoas] TINYINT NOT NULL,
    [Desconto] TINYINT NOT NULL,
    [ValorFinal] INT NOT NULL,

    CONSTRAINT [PK_Hospedagem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Hospedagem_Chale] FOREIGN KEY ([ChaleId]) REFERENCES [Chale]([Id]),
    CONSTRAINT [FK_Hospedagem_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id]),
)

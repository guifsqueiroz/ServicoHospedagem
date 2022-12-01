CREATE TABLE [dbo].[Cliente]
(
	 [Id] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [Rg] VARCHAR(15) NOT NULL,
    [Endereco] NVARCHAR(100) NOT NULL,
    [Bairro] NVARCHAR(50) NOT NULL,   
    [Cidade] NVARCHAR(30) NOT NULL,
    [Estado] VARCHAR(2) NOT NULL,
    [CEP] VARCHAR(10) NOT NULL,
    [Nascimento] NVARCHAR(10) NOT NULL,

    CONSTRAINT [PK_Cliente] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Cliente_Rg] UNIQUE([Rg])
)
Go
CREATE INDEX [IX_Cliente_Rg] ON [Cliente]([Rg])
GO
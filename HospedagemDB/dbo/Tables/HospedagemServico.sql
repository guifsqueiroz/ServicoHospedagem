CREATE TABLE [dbo].[HospedagemServico]
(
	[ServicoId] INT NOT NULL,
    [HospedagemId] INT NOT NULL,
    [DataServico] DATETIME NOT NULL DEFAULT(GETDATE()), 
    [ValorServico] INT NULL,

    CONSTRAINT [PK_HospedagemServico] PRIMARY KEY ([ServicoId],[HospedagemId])

)

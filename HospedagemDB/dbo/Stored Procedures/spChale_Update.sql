CREATE PROCEDURE [dbo].[spChale_Update]
	@Localizacao NVARCHAR(300),
    @Capacidade TINYINT,
    @ValorAltaEstacao INT,
    @ValorBaixaEstacao INT,  
    @Id INT
AS
begin
	update [dbo].[Chale]
	set 
    Localizacao = @Localizacao,
    Capacidade = @Capacidade,
    ValorAltaEstacao = @ValorAltaEstacao,
    ValorBaixaEstacao = @ValorBaixaEstacao    
    where
    Id = @Id;

end


CREATE PROCEDURE [dbo].[spChale_Insert]
	@Localizacao NVARCHAR(300),
    @Capacidade TINYINT,
    @ValorAltaEstacao INT,
    @ValorBaixaEstacao INT   
AS
begin
	insert into [dbo].[Chale]
	(Localizacao,
    Capacidade,
    ValorAltaEstacao,
    ValorBaixaEstacao)
    values
    (@Localizacao,
    @Capacidade,
    @ValorAltaEstacao,
    @ValorBaixaEstacao);

end


CREATE PROCEDURE [dbo].[spHospedagem_Update]
	@Id INT, 
    @ChaleId INT, 
    @ClienteId INT,
    @Estado BIT, 
    @DataInicio DATETIME,
    @DataFim   DATETIME,
    @QtdPessoas TINYINT,
    @Desconto TINYINT,
    @ValorFinal INT
As
begin
	update [dbo].[Hospedagem]
    set
    ChaleId = @ChaleId,
    ClienteId = @ClienteId,
    Estado = @Estado,
    DataInicio = @DataInicio,
    DataFim = @DataFim,
    QtdPessoas = @QtdPessoas,
    Desconto = @Desconto,
    ValorFinal = @ValorFinal
    Where
    Id = @Id;
end

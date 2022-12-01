CREATE PROCEDURE [dbo].[SpHospedagem_Insert]
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
	insert into [dbo].[Hospedagem]
	(Id, 
    ChaleId, 
    ClienteId,
    Estado, 
    DataInicio,
    DataFim,
    QtdPessoas,
    Desconto,
    ValorFinal)
    values
    (@Id, 
    @ChaleId, 
    @ClienteId,
    @Estado, 
    @DataInicio,
    @DataFim,
    @QtdPessoas,
    @Desconto,
    @ValorFinal);
end

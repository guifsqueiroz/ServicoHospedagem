CREATE PROCEDURE [dbo].[spHospedagemServico_Insert]
	@ServicoId INT,
    @HospedagemId INT,
	@DataServico Date,
	@ValorServico INT
AS
begin
	insert into [dbo].[HospedagemServico]
	(ServicoId,
    HospedagemId,
	DataServico,
	ValorServico) 
	values 
	(@ServicoId,
    @HospedagemId,
	@DataServico,
	@ValorServico);
end
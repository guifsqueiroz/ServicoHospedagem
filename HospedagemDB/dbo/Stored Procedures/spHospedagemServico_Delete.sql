CREATE PROCEDURE [dbo].[spHospedagemServico_Delete]
	@ServicoId int,
	@HospedagemId int
AS
begin
	delete
	from [dbo].[HospedagemServico]
	where HospedagemId = @HospedagemId and ServicoId = @ServicoId;
end

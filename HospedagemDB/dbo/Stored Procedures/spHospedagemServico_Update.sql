CREATE PROCEDURE [dbo].[spHospedagemServico_Update]
	@ServicoId INT,
    @HospedagemId INT,
	@NewServicoId INT
AS
begin
	update [dbo].[HospedagemServico]
	set 
	ServicoId = @NewServicoId
    where
    ServicoId = @ServicoId and HospedagemId = @HospedagemId;

end
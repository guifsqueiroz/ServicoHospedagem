CREATE PROCEDURE [dbo].[spHospedagemServico_GetAll]
	@HospedagemId INT
AS
begin
	select 
		*
	from [dbo].[HospedagemServico]
	where HospedagemId = @HospedagemId;
end

CREATE PROCEDURE [dbo].[spServico_GetAll]
AS
begin
	select 
		*
	from [dbo].[Servico];
end

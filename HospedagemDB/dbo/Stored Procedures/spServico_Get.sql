CREATE PROCEDURE [dbo].[spServico_Get]
	@Id int
AS
begin
	select 
		*
	from [dbo].[Servico]
	where Id = @Id;
end

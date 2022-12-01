CREATE PROCEDURE [dbo].[spServico_Delete]
	@Id int
AS
begin
	delete
	from [dbo].[Servico]
	where Id = @Id;
end

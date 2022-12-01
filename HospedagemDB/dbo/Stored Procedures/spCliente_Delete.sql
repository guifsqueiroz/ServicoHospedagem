CREATE PROCEDURE [dbo].[spCliente_Delete]
	@Id int
AS
begin
	delete
	from [dbo].[Cliente]
	where Id = @Id;
end

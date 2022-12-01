CREATE PROCEDURE [dbo].[spCliente_Get]
	@Id int
AS
begin
	select 
		*
	from [dbo].[Cliente]
	where Id = @Id;
end

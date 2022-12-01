CREATE PROCEDURE [dbo].[spCliente_GetAll]
AS
begin
	select 
		*
	from [dbo].[Cliente];
end

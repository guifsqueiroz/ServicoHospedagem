CREATE PROCEDURE [dbo].[spChale_Get]
	@Id int
AS
begin
	select 
		*
	from [dbo].[Chale]
	where Id = @Id;
end

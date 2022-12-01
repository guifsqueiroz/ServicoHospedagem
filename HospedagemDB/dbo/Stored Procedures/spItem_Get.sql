CREATE PROCEDURE [dbo].[spItem_Get]
	@Id int
AS
begin
	select 
		*
	from [dbo].[Item]
	where Id = @Id;
end

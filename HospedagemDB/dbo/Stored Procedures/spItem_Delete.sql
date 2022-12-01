CREATE PROCEDURE [dbo].[spItem_Delete]
	@Id int
AS
begin
	delete
	from [dbo].[Item]
	where Id = @Id;
end

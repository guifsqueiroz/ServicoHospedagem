CREATE PROCEDURE [dbo].[spChale_Delete]
	@Id int
AS
begin
	delete
	from [dbo].[Chale]
	where Id = @Id;
end

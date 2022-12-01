CREATE PROCEDURE [dbo].[spChaleItem_Delete]
	@ChaleId int,
	@ItemId int
AS
begin
	delete
	from [dbo].[ChaleItem]
	where ChaleId = @ChaleId and ItemId = @ItemId;
end

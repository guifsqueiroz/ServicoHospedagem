CREATE PROCEDURE [dbo].[spChaleItem_Update]
	@ChaleId INT,
    @ItemId INT,
    @NewItemId INT
AS
begin
	update [dbo].[ChaleItem]
	set 
    ItemId = @NewItemId
    where
    ChaleId = @ChaleId and ItemId = ItemId;

end
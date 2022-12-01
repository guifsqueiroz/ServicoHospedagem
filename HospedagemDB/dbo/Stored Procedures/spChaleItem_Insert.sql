CREATE PROCEDURE [dbo].[spChaleItem_Insert]
	@ChaleId INT,
    @ItemId INT 
AS
begin
	insert into [dbo].[ChaleItem]
	(ChaleId, ItemId) 
	values 
	(@ChaleId,
	@ItemId);
end
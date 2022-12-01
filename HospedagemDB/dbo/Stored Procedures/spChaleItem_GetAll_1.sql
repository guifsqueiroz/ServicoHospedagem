CREATE PROCEDURE [dbo].[spChaleItem_GetAll]
	@ChaleId INT
AS
begin
	select 
		*
	from [dbo].[ChaleItem]
	where ChaleId = @ChaleId;
end

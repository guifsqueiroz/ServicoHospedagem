CREATE PROCEDURE [dbo].[spChateItem_GetAll]
	@ChaleId INT
AS
begin
	select 
		*
	from [dbo].[ChaleItem]
	where ChaleId = @ChaleId;
end

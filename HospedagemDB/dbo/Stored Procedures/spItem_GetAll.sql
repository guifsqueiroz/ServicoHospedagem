CREATE PROCEDURE [dbo].[spItem_GetAll]
AS
begin
	select 
		*
	from [dbo].[Item];
end

CREATE PROCEDURE [dbo].[spHospedagem_GetAll]
AS
begin
	select 
		*
	from [dbo].[Hospedagem];
end

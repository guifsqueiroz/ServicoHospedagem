CREATE PROCEDURE [dbo].[spTelefone_Delete]
	@Numero int
AS
begin
	delete
	from [dbo].[Telefone]
	where Numero = @Numero;
end

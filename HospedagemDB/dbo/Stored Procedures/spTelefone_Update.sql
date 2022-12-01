CREATE PROCEDURE [dbo].[spTelefone_Update]
	@ClienteId int,
    @Numero NVARCHAR(20),
    @TipoTelefone VARCHAR(10)
AS
begin
	update [dbo].[Telefone]
	set 
    Numero = @Numero,
    TipoTelefone = @TipoTelefone
    where
    ClienteId = @ClienteId;

end
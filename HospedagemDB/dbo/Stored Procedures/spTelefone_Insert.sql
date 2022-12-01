CREATE PROCEDURE [dbo].[spTelefone_Insert]
	@ClienteId int,
    @Numero NVARCHAR(20),
    @TipoTelefone VARCHAR(10)
AS
begin
	insert into [dbo].[Telefone]
	(Numero,
    ClienteId,
    TipoTelefone)
    values
    (@Numero,
    @ClienteId,
    @TipoTelefone);
end
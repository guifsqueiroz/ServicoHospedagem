CREATE PROCEDURE [dbo].[spServico_Insert]
	@Nome NVARCHAR(30),
    @Valor INT 
AS
begin
	insert into [dbo].[Servico]
	(Nome,
    Valor)
    values
    (@Nome,
    @Valor);

end


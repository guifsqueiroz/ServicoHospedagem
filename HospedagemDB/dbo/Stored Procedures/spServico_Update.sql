CREATE PROCEDURE [dbo].[spServico_Update]
	@Id int,
    @Nome NVARCHAR(30),
    @Valor INT
AS
begin
	update [dbo].[Servico]
	set 
    Nome = @Nome,
    Valor = @Valor
    where
    Id = @Id;

end


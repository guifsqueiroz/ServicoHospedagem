CREATE PROCEDURE [dbo].[spItem_Insert]
	@Nome NVARCHAR(50),
    @Descricao TEXT 
AS
begin
	insert into [dbo].[Item]
	(Nome,
    Descricao)
    values
    (@Nome,
    @Descricao);

end


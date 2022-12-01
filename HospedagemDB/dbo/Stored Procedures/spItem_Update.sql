CREATE PROCEDURE [dbo].[spItem_Update]
	@Id int,
    @Nome NVARCHAR(50),
    @Descricao TEXT
AS
begin
	update [dbo].[Item]
	set 
    Nome = @Nome,
    Descricao = @Descricao   
    where
    Id = @Id;

end


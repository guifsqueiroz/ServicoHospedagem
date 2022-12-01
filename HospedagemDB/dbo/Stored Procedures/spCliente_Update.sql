CREATE PROCEDURE [dbo].[spCliente_Update]
	@Id int,
    @Nome NVARCHAR(80),
    @Rg VARCHAR(15),
    @Endereco NVARCHAR(100),
    @Bairro NVARCHAR(50),   
    @Cidade NVARCHAR(30),
    @Estado VARCHAR(2),
    @CEP VARCHAR(10),
    @Nascimento NVARCHAR(10) 
AS
begin
	update [dbo].[Cliente]
	set 
    Nome = @Nome,
    Rg = @Rg,
    Endereco = @Endereco,
    Bairro = @Bairro,    
    Cidade = @Cidade, 
    Estado = @Estado,
    CEP = @CEP,
    Nascimento = @Nascimento
    where
    Id = @Id;

end


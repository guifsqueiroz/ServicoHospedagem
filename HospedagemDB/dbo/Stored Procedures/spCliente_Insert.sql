CREATE PROCEDURE [dbo].[spCliente_Insert]
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
	insert into [dbo].[Cliente]
	(Nome,
    Rg,
    Endereco,
    Bairro,   
    Cidade,
    Estado,
    CEP,
    Nascimento)
    values
    (@Nome,
    @Rg,
    @Endereco,
    @Bairro,   
    @Cidade,
    @Estado,
    @CEP,
    @Nascimento);

end


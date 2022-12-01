CREATE PROCEDURE [dbo].[spTelefone_GetAll]
AS
begin
	SELECT
    [dbo].[Telefone].[Numero],
    [dbo].[Cliente].[Id],
    [dbo].[Cliente].[Nome]
FROM 
    [dbo].[Telefone]
    INNER JOIN [dbo].[Cliente]
     ON [dbo].[Telefone].[ClienteId] = [dbo].[Cliente].[Id]
end


CREATE PROCEDURE [dbo].[spHospedagem_Delete]
	@Id int,
	@Estado bit
AS
begin
	update [dbo].[Hospedagem] 
	set Estado = @Estado
	where Id = @Id;
end

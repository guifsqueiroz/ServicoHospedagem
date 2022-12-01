using DataAccess.DbAccess;
using DataAccess.Models;


namespace DataAccess.Data;

public class ClienteData : IClienteData
{
	private readonly ISqlDataAccess _db;

	public ClienteData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<Cliente>> GetAll()
	=> _db.LoadData<Cliente, dynamic>("dbo.spCliente_GetAll", new { });

	public async Task<Cliente?> Get(int id)
	{
		var results = await _db.LoadData<Cliente, dynamic>(
			"dbo.spCliente_Get",
			new { Id = id });
		return results.FirstOrDefault();
	}

	public Task InsertCliente(Cliente cliente)
	=> _db.SaveData("dbo.spCliente_Insert", new { cliente.Nome, cliente.Rg, cliente.Endereco, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.CEP, cliente.Nascimento });

	public Task UpdateCliente(Cliente cliente)
	=> _db.SaveData("dbo.spCliente_Update", cliente);

	public Task DeleteCliente(int id)
	=> _db.SaveData("dbo.spCliente_Delete", new { Id = id });
}

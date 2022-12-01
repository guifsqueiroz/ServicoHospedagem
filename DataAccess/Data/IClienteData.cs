using DataAccess.Models;

namespace DataAccess.Data;

public interface IClienteData
{
    Task DeleteCliente(int id);
    Task<Cliente?> Get(int id);
    Task<IEnumerable<Cliente>> GetAll();
    Task InsertCliente(Cliente cliente);
    Task UpdateCliente(Cliente cliente);
}

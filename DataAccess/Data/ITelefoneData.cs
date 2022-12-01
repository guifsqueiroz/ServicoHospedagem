using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ITelefoneData
    {
        Task DeleteTelefone(int numero);
        Task<Telefone?> Get(int id);
        Task<IEnumerable<Telefone>> GetAll();
        Task InsertTelefone(Telefone telefone);
        Task UpdateTelefone(Telefone telefone);
    }
}
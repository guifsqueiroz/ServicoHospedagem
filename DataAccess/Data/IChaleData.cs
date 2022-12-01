using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IChaleData
    {
        Task DeleteChale(int id);
        Task<Chale?> Get(int id);
        Task<IEnumerable<Chale>> GetAll();
        Task InsertChale(Chale chale);
        Task UpdateChale(Chale chale);
    }
}
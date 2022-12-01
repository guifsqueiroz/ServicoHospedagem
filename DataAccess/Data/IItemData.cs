using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IItemData
    {
        Task DeleteItem(int id);
        Task<Item?> Get(int id);
        Task<IEnumerable<Item>> GetAll();
        Task InsertItem(Item item);
        Task UpdateItem(Item item);
    }
}
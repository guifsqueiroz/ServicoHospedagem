using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IChaleItemData
    {
        Task DeleteChaleItem(ChaleItem chaleItem);
        Task<IEnumerable<ChaleItem>> GetAll(int chaleId);
        Task InsertChaleItem(ChaleItem chaleItem);
        Task UpdateChaleItem(int chaleId, int itemId, int newItemId);
    }
}
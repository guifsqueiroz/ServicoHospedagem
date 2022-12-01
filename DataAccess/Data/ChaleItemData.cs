using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class ChaleItemData : IChaleItemData
    {

        private readonly ISqlDataAccess _db;

        public ChaleItemData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<ChaleItem>> GetAll(int chaleId)
         => _db.LoadData<ChaleItem, dynamic>("dbo.spChaleItem_GetAll", new { ChaleId = chaleId });

        public Task InsertChaleItem(ChaleItem chaleItem)
        => _db.SaveData("dbo.spChaleItem_Insert", new
        {
            chaleItem.ChaleId,
            chaleItem.ItemId,
        });

        public Task UpdateChaleItem(int chaleId, int itemId, int newItemId)
        => _db.SaveData("dbo.spChaleItem_Update", new
        {
            ChaleId = chaleId,
            ItemId = itemId,
            NewItemId = newItemId
        });

        public Task DeleteChaleItem(ChaleItem chaleItem)
        => _db.SaveData("dbo.spChaleItem_Delete", chaleItem);
    }
}

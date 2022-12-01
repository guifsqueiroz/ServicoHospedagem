using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class ItemData : IItemData
{
    private readonly ISqlDataAccess _db;

    public ItemData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Item>> GetAll()
    => _db.LoadData<Item, dynamic>("dbo.spItem_GetAll", new { });

    public async Task<Item?> Get(int id)
    {
        var results = await _db.LoadData<Item, dynamic>(
            "dbo.spItem_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertItem(Item item)
    => _db.SaveData("dbo.spItem_Insert", new { item.Nome, item.Descricao });

    public Task UpdateItem(Item item)
    => _db.SaveData("dbo.spItem_Update", item);

    public Task DeleteItem(int id)
    => _db.SaveData("dbo.spItem_Delete", new { Id = id });

}


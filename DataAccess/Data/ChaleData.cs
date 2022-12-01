using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class ChaleData : IChaleData
{

    private readonly ISqlDataAccess _db;

    public ChaleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Chale>> GetAll()
    => _db.LoadData<Chale, dynamic>("dbo.spChale_GetAll", new { });

    public async Task<Chale?> Get(int id)
    {
        var results = await _db.LoadData<Chale, dynamic>(
            "dbo.spChale_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertChale(Chale chale)
    => _db.SaveData("dbo.spChale_Insert", new
    {
        chale.Localizacao,
        chale.Capacidade,
        chale.ValorAltaEstacao,
        chale.ValorBaixaEstacao
    });

    public Task UpdateChale(Chale chale)
    => _db.SaveData("dbo.spChale_Update", chale);

    public Task DeleteChale(int id)
    => _db.SaveData("dbo.spChale_Delete", new { Id = id });

}


using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;


//Numero
//ClienteId
//TipoTelefone

public class TelefoneData : ITelefoneData
{

    private readonly ISqlDataAccess _db;

    public TelefoneData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Telefone>> GetAll()
    => _db.LoadData<Telefone, dynamic>("dbo.spTelefone_GetAll", new { });

    public async Task<Telefone?> Get(int id)
    {
        var results = await _db.LoadData<Telefone, dynamic>(
            "dbo.spTelefone_Get",
            new { ClienteId = id });
        return results.FirstOrDefault();
    }

    public Task InsertTelefone(Telefone telefone)
    => _db.SaveData("dbo.spTelefone_Insert", telefone);

    public Task UpdateTelefone(Telefone telefone)
    => _db.SaveData("dbo.spTelefone_Update", telefone);

    public Task DeleteTelefone(int numero)
    => _db.SaveData("dbo.spTelefone_Delete", new { Numero = numero });

}


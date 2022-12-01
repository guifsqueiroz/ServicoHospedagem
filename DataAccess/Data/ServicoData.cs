
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class ServicoData : IServicoData
{

    private readonly ISqlDataAccess _db;

    public ServicoData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<Servico>> GetAll()
    => _db.LoadData<Servico, dynamic>("dbo.spServico_GetAll", new { });

    public async Task<Servico?> Get(int id)
    {
        var results = await _db.LoadData<Servico, dynamic>(
            "dbo.spServico_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertServico(Servico servico)
    => _db.SaveData("dbo.spServico_Insert", new { servico.Nome, servico.Valor });

    public Task UpdateServico(Servico servico)
    => _db.SaveData("dbo.spServico_Update", servico);

    public Task DeleteServico(int id)
    => _db.SaveData("dbo.spServico_Delete", new { Id = id });

}


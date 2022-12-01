using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class HospedagemServicoData : IHospedagemServicoData
    {
        private readonly ISqlDataAccess _db;

        public HospedagemServicoData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<HospedagemServico>> GetAll(int hospedagemId)
        => _db.LoadData<HospedagemServico, dynamic>("dbo.spHospedagemServico_GetAll", new { HospedagemId = hospedagemId });

        public Task InsertHospedagemServico(HospedagemServico host)
        => _db.SaveData("dbo.spHospedagemServico_Insert", new
        {
            host.ServicoId,
            host.HospedagemId,
            host.DataServico,
            host.ValorServico
        });

        public Task UpdateHospedagemServico(HospedagemServico host)
        => _db.SaveData("dbo.spHospedagemServico_Update", host);

        public Task DeleteHospedagemServico(HospedagemServico host)
        => _db.SaveData("dbo.spHospedagemServico_Delete", host);
    }
}

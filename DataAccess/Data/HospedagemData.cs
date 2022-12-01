using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class HospedagemData : IHospedagemData
    {
        private readonly ISqlDataAccess _db;

        public HospedagemData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Hospedagem>> GetAll()
        => _db.LoadData<Hospedagem, dynamic>("dbo.spHospedagem_GetAll", new { });

        public Task InsertHospedagem(Hospedagem hospedagem)
        => _db.SaveData("dbo.spHospedagem_Insert", new
        {
            hospedagem.ChaleId,
            hospedagem.ClienteId,
            hospedagem.Estado,
            hospedagem.DataInicio,
            hospedagem.DataFim,
            hospedagem.QtdPessoas,
            hospedagem.Desconto,
            hospedagem.ValorFinal
        });

        public Task UpdateHospedagem(Hospedagem hospedagem)
        => _db.SaveData("dbo.spHospedagem_Update", hospedagem);

        public Task DeleteHospedagem(int id, bool estado)
        => _db.SaveData("dbo.spHospedagem_Delete", new { Id = id, Estado = estado });
    }
}

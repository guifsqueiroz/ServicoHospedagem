using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IHospedagemServicoData
    {
        Task DeleteHospedagemServico(HospedagemServico host);
        Task<IEnumerable<HospedagemServico>> GetAll(int hospedagemId);
        Task InsertHospedagemServico(HospedagemServico host);
        Task UpdateHospedagemServico(HospedagemServico host);
    }
}
using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IServicoData
    {
        Task DeleteServico(int id);
        Task<Servico?> Get(int id);
        Task<IEnumerable<Servico>> GetAll();
        Task InsertServico(Servico servico);
        Task UpdateServico(Servico servico);
    }
}
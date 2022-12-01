using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IHospedagemData
    {
        Task DeleteHospedagem(int id, bool estado);
        Task<IEnumerable<Hospedagem>> GetAll();
        Task InsertHospedagem(Hospedagem hospedagem);
        Task UpdateHospedagem(Hospedagem hospedagem);
    }
}
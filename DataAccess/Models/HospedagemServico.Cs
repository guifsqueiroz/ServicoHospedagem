namespace DataAccess.Models
{
    public class HospedagemServico
    {
        public int ServicoId  { get; set; }
        public int HospedagemId { get; set; }
        public DateTime DataServico { get; set; }
        public int ValorServico { get; set; }
    }
}
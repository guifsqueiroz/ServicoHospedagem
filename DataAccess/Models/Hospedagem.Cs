namespace DataAccess.Models
{
    public class Hospedagem
    {
        public int Id  { get; set; }
        public int ChaleId { get; set; }
        public int ClienteId { get; set; }
        public bool Estado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int QtdPessoas { get; set; }
        public int Desconto { get; set; }
        public int ValorFinal { get; set; }
    }
}
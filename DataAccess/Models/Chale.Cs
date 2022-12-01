namespace DataAccess.Models
{
    
    public class Chale
    {
        public int Id { get; set; }
        public string Localizacao { get; set; } = default!;
        public int Capacidade { get; set; }
        public int ValorAltaEstacao { get; set; }
        public int ValorBaixaEstacao { get; set; }
    }
}
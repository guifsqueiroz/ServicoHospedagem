namespace DataAccess.Models
{
    public class Telefone
    {
        public string Numero  { get; set; } = default!;
        public int ClienteId { get; set; }
        public string TipoTelefone { get; set; } = default!;
    }
}
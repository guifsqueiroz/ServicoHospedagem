namespace DataAccess.Models
{
    public class Item
    {
        public int Id  { get; set; }
        public string Nome { get; set; } = default!;
        public string Descricao { get; set; } = default!;
    }
}
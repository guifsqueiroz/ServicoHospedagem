namespace DataAccess.Models
{
  
    public class Cliente
    {
        public int Id  { get; set; }
        public string Nome  { get; set; }  = default!;
        public string Rg { get; set; }  = default!;
        public string Endereco { get; set; }  = default!;
        public string Bairro { get; set; } = default!;
        public string Cidade { get; set; } = default!;
        public string Estado { get; set; } = default!;
        public string CEP { get; set; } = default!;
        public string Nascimento { get; set; } = default!;

    }
}
namespace SistemaFerias.API.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
    }
}

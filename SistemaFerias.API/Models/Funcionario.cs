namespace SistemaFerias.API.Models
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}

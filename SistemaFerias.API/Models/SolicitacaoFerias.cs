namespace SistemaFerias.API.Models
{
    public class SolicitacaoFerias
    {
        public int Id { get; set; }
        public string NomeFuncionario { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Dias { get; set; } // 20 ou 30 dias.
        public string Õbservacoes { get; set; } = string.Empty;
        public DateTime DataSolicitacao { get; set; } = DateTime.Now;
    }
}

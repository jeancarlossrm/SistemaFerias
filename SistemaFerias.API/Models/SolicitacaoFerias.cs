using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaFerias.API.Models
{
    public class SolicitacaoFerias
    {
        public int Id { get; set; }
        public int NomeFuncionarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Dias { get; set; } // 20 ou 30 dias.
        public string? Observacoes { get; set; }
        public DateTime DataSolicitacao { get; set; } = DateTime.Now;

        [ForeignKey("NomeFuncionarioId")]
        [JsonIgnore]
        public Funcionario? Funcionario { get; set; }

    }

}

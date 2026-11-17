using Microsoft.EntityFrameworkCore;
using SistemaFerias.API.Models;

namespace SistemaFerias.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) 
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<SolicitacaoFerias> SolicitacoesFerias { get; set; }

    }
}

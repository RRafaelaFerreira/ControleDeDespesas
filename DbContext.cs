using Microsoft.EntityFrameworkCore;

namespace DespesasGerais
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Alimentacao> Alimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=localhost; Database=DB23015; UserId=DB23015; Password:DB23015; MultipleActiveResultSets=true; Encrypt=TES; TrustServerCertificate=YES");
    }
}


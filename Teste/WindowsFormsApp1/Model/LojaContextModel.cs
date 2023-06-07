using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1.Model
{
    public class LojaContextModel : DbContext
    {
        public DbSet<ProdutoController> Produtos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TesteDB;Trusted_Connection=true;");
        }
    }
}

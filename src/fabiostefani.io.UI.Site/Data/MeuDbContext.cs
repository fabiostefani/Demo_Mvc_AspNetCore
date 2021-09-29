using fabiostefani.io.UI.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace fabiostefani.io.UI.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
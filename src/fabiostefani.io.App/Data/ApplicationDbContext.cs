using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fabiostefani.io.App.ViewModels;

namespace fabiostefani.io.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<fabiostefani.io.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}

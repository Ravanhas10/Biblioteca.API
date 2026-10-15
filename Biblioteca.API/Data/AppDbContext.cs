using Microsoft.EntityFrameworkCore;
using Biblioteca.API.Models;

namespace Biblioteca.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }
    }
}

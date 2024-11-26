namespace PosgradoAPI.DataBaseContext
{
    using Microsoft.EntityFrameworkCore;
    using PosgradoAPI.Core.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Solicitud> Solicitud { get; set; }
     
    }

}

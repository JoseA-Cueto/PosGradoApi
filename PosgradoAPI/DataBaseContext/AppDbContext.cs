namespace PosgradoAPI.DataBaseContext
{
    using Microsoft.EntityFrameworkCore;
    using PosgradoAPI.Core.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Professional> Professional { get; set; }
        public DbSet<GraduateProgram> GraduateProgram { get; set; }
        public DbSet<Thesis> Thesis { get; set; }
        public DbSet<Professor> Professor { get; set; }
    }

}

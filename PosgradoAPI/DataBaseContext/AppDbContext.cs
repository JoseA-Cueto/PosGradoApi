namespace PosgradoAPI.DataBaseContext
{
    using Microsoft.EntityFrameworkCore;
    using PosgradoAPI.Core.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Participante> Participante { get; set; }
        public DbSet<TomoFolio> TomoFolio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<TomoFolio>()
                .HasKey(t => new { t.id_persona, t.id_actividad });  

         
            
        }
    }
}

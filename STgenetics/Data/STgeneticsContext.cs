using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using STgenetics.Models;

namespace STgenetics.Data
{
    public class STgeneticsContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public STgeneticsContext(DbContextOptions<STgeneticsContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Animal> Animal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de entidades y propiedades
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.AnimalId);
                entity.Property(e => e.Nombre).HasMaxLength(20);
                entity.Property(e => e.Raza).HasMaxLength(100);
                entity.Property(e => e.FechaNacimiento).HasColumnType("DATE");
                entity.Property(e => e.Sexo).HasMaxLength(10);
                entity.Property(e => e.Precio).HasColumnType("DECIMAL(18, 2)");
                entity.Property(e => e.Estado).HasMaxLength(20);
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = _configuration.GetConnectionString("STgeneticsContext");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}


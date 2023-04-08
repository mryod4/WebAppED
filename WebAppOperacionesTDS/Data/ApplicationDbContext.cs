using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static WebAppOperacionesTDS.Data.ApplicationDbContext;

namespace WebAppOperacionesTDS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public class Usuario : IdentityUser
        {
            public string? Nombres { get; set; }

            public string? APaterno { get; set; }
            public string? AMaterno { get; set; }
            public string? DNI { get; set; }
            public string? Direccion { get; set; }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>(EntityTypeBuilder =>
            {

                EntityTypeBuilder.ToTable("AspNetUsers");
                EntityTypeBuilder.Property(u => u.UserName).HasMaxLength(100).HasDefaultValue(0);
                EntityTypeBuilder.Property(u => u.Nombres).HasMaxLength(60).HasDefaultValue(0); ;
                EntityTypeBuilder.Property(u => u.APaterno).HasMaxLength(60);
                EntityTypeBuilder.Property(u => u.AMaterno).HasMaxLength(60);
                EntityTypeBuilder.Property(u => u.DNI).HasMaxLength(8);
                EntityTypeBuilder.Property(u => u.Direccion).HasMaxLength(60);

            });
        }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public virtual DbSet<WebAppOperacionesTDS.Models.Cliente> Cliente { get; set; }

        public virtual DbSet<WebAppOperacionesTDS.Models.Lugar> Lugar { get; set; }
        public virtual DbSet<WebAppOperacionesTDS.Models.Servicio> Servicio { get; set; }
        public virtual DbSet<WebAppOperacionesTDS.Models.Operacion> Operacion { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IR85KNJ;Database=DBOperacion2022-IITDS;" +
                "User id=sa;Password=159;MultipleActiveResultSets=True");
        }
    }
}
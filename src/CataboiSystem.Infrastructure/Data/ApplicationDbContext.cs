using CataboiSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CataboiSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Animal> Animais { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Rebanho> Rebanhos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=cataboi_api;User=root;Password=Senha123*;",
                    ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=cataboi_api;User=root;Password=Senha123*;"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações do modelo, se necessário
            modelBuilder.Entity<Admin>().HasKey(a => a.AdminId);
            modelBuilder.Entity<Animal>().HasKey(a => a.Idanimal);
            modelBuilder.Entity<Cliente>().HasKey(a => a.ClienteId);
            modelBuilder.Entity<Evento>().HasKey(a => a.IdevenR);
            modelBuilder.Entity<Rebanho>().HasKey(a => a.Id);
            modelBuilder.Entity<Usuario>().HasKey(a => a.Idusu);
            
            // Você não precisa configurar o IdentityUser aqui, o Identity fará isso automaticamente.
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

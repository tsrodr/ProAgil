using Microsoft.EntityFrameworkCore;
using ProAgil.Dominio.Entidades;
using ProAgil.Repositorio.Config;

namespace ProAgil.Repositorio.Contexto
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Local> Locais { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new EventoConfiguration());
            modelBuilder.ApplyConfiguration(new TemaConfiguration());
            modelBuilder.ApplyConfiguration(new LocalConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }



}

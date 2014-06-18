using dominio.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace dominio.Models
{
    public partial class BaseTPContext : DbContext
    {
        static BaseTPContext()
        {
            Database.SetInitializer<BaseTPContext>(null);
        }

        public BaseTPContext()
            : base("Name=BaseTPContext")
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Proyecto> Proyectoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new FactorMap());
            modelBuilder.Configurations.Add(new GerenteMap());
            modelBuilder.Configurations.Add(new ProyectoMap());
        }
    }
}

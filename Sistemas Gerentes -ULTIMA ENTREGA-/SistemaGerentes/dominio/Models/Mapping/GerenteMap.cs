using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace dominio.Models.Mapping
{
    public class GerenteMap : EntityTypeConfiguration<Gerente>
    {
        public GerenteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Gerente");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.dni).HasColumnName("dni");
        }
    }
}

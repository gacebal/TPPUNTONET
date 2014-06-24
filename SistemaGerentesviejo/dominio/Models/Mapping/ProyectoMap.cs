using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace dominio.Models.Mapping
{
    public class ProyectoMap : EntityTypeConfiguration<Proyecto>
    {
        public ProyectoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired();

            this.Property(t => t.Descripcion)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Proyecto");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.GerenteId).HasColumnName("GerenteId");

            // Relationships
            this.HasRequired(t => t.Gerente)
                .WithMany(t => t.Proyectoes)
                .HasForeignKey(d => d.GerenteId);

        }
    }
}

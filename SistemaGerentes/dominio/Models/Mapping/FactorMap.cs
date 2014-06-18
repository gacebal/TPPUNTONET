using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace dominio.Models.Mapping
{
    public class FactorMap : EntityTypeConfiguration<Factor>
    {
        public FactorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired();

            this.Property(t => t.Descripcion)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Factor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.Ponderacion).HasColumnName("Ponderacion");
            this.Property(t => t.ProyectoId).HasColumnName("ProyectoId");

            // Relationships
            this.HasRequired(t => t.Proyecto)
                .WithMany(t => t.Factors)
                .HasForeignKey(d => d.ProyectoId);

        }
    }
}

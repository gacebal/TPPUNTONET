using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace dominio.Models.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Categoria");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.FactorId).HasColumnName("FactorId");

            // Relationships
            this.HasRequired(t => t.Factor)
                .WithMany(t => t.Categorias)
                .HasForeignKey(d => d.FactorId);

        }
    }
}

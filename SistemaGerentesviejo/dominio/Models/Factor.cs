using System;
using System.Collections.Generic;

namespace dominio.Models
{
    public partial class Factor
    {
        public Factor()
        {
            this.Categorias = new List<Categoria>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short Ponderacion { get; set; }
        public short ProyectoId { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}

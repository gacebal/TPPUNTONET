using System;
using System.Collections.Generic;

namespace dominio.Models
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Factors = new List<Factor>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public short GerenteId { get; set; }
        public virtual ICollection<Factor> Factors { get; set; }
        public virtual Gerente Gerente { get; set; }
    }
}

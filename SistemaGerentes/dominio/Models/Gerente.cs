using System;
using System.Collections.Generic;

namespace dominio.Models
{
    public partial class Gerente
    {
        public Gerente()
        {
            this.Proyectoes = new List<Proyecto>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public short dni { get; set; }
        public virtual ICollection<Proyecto> Proyectoes { get; set; }
    }
}

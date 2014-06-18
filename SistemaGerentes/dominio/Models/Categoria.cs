using System;
using System.Collections.Generic;

namespace dominio.Models
{
    public partial class Categoria
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public short Valor { get; set; }
        public short FactorId { get; set; }
        public virtual Factor Factor { get; set; }
    }
}

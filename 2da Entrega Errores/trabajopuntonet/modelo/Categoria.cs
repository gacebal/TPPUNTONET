//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categoria
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public short Valor { get; set; }
        public short FactorId { get; set; }
    
        public virtual Factor Factor { get; set; }
    }
}

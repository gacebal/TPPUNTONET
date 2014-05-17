using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_punto_net
{
    class Proyecto
    {
        private int id;
        private Gerente gerente;
        private string nombre;
        private int estado;
        private string descripcion;

        public int Id { get; set; }
        public Gerente Gerente { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public string Descripcion { get; set; }
    }
}

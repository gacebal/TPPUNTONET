using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_punto_net
{
    class Factor
    {
        private int id;
        private int estado;
        private string descripcion;
        private List<Categoria> categorias;

        public int Id { get; set; }
        public int Estado { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categorias { get; set; }
        public int Valores { get; set; }
    }
}

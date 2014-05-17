using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_punto_net
{
    class DetalleCaracterizacion
    {
        private int id;
        private int codigo;
        private Factor factor;
        private int raiting;
        private int peso;

        public int Id { get; set; }
        public int Codigo { get; set; }
        public Factor Factor { get; set; }
        public int Raiting { get; set; }
        public int Peso { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_punto_net
{
    class Caracterizacion
    {
        private int id;
        private Proyecto proyecto;
        private float resultado;
        private string obesrvaciones;

        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public float Resultado { get; set; }
        public string Observaciones { get; set; }
    }
}

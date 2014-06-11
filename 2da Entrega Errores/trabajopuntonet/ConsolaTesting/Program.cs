using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;

namespace ConsolaTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ModeloTPContainer())
            {

                Categoria cat1 = new Categoria();
                Categoria cat2 = new Categoria();
                Categoria cat3 = new Categoria();
                cat1.Nombre = "malo"; cat1.Valor = 0;
                cat2.Nombre = "regular"; cat2.Valor = 1;
                cat3.Nombre = "bueno"; cat3.Valor = 2;

                Factor fac1 = new Factor();
                fac1.Nombre = "Calidad";
                fac1.Descripcion = "Factor que mide la calidad";
                fac1.Categoria.Add(cat1);
                fac1.Categoria.Add(cat2);
                fac1.Categoria.Add(cat3);

                ctx.FactorSet.Add(fac1);
                ctx.SaveChanges();

            }

        }
    }
}

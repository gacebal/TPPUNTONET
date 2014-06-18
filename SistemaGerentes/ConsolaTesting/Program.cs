using dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new BaseTPContext();

            Gerente ger1 = new Gerente();
            ger1.dni = 22;
            ger1.Nombre = "Guille Garcia";

            Proyecto pro1 = new Proyecto();
            pro1.Nombre = "Encarar Gordas";
            pro1.Fecha = new DateTime(2014, 05, 28);
            pro1.Descripcion = "Proyecto que describe como levantar gordas";
            pro1.GerenteId = 2;

            Categoria cat1 = new Categoria();
            Categoria cat2 = new Categoria();
            Categoria cat3 = new Categoria();
            cat1.Nombre = "gorda"; cat1.Valor = 0;
            cat2.Nombre = "gordasa"; cat2.Valor = 1;
            cat3.Nombre = "remil gorda!"; cat3.Valor = 2;

            Factor fac1 = new Factor();
            fac1.Nombre = "Peso";
            fac1.Descripcion = "Describe el peso de la victima";
            fac1.Categorias.Add(cat1);
            fac1.Categorias.Add(cat2);
            fac1.Categorias.Add(cat3);

            ctx.Categorias.Add(cat1);
            ctx.Proyectoes.Add(pro1);
            ctx.Gerentes.Add(ger1);
            ctx.Factors.Add(fac1);

            ctx.SaveChanges(); 

        }
    }
}

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
            int tecla = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("-- PROGRAMA TEST --");
                Console.WriteLine("Seleccione una accion a realizar");
                Console.WriteLine("1 - CREAR");
                Console.WriteLine("2 - MODIFICAR");
                Console.WriteLine("3 - CONSULTAR");
                Console.WriteLine("0 - SALIR");
                tecla = Convert.ToInt32(Console.ReadLine());
                
                var ctx = new BaseTPContext();
                switch (tecla)
                {
                    case 1:
                        Console.WriteLine("Solo se dara de alta un gerente");
                        Gerente ger1 = new Gerente();
                        Console.WriteLine("Ingrese el nombre del Gerente nuevo");
                        ger1.Nombre = Console.ReadLine();
                        //Console.WriteLine("Ingrese el DNI del gerente nuevo");
                        ger1.dni = 2244;
                        ctx.Gerentes.Add(ger1);
                        ctx.SaveChanges();
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el ID del gerente que desea consultar");
                        short id_ger = Convert.ToInt16(Console.ReadLine());
                        var ger2 = ctx.Gerentes.Find(id_ger);
                        
                       
                        break;


                    
                }

                Console.WriteLine("Ingrese nuevamente la Opcion:");
                tecla = Convert.ToInt32(Console.ReadLine());

            } while (tecla != 0);
           




        }
    }
}

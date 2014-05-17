using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp_punto_net
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Apellido = "gaby";
            g.Nombre = "roba yerba";

            string connectionString = "Server = localhost; Database = tp_punto_net; User Id = Negro; Password = hpr789";

            string queryString = "select * from Gerente";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                reader.Close();
            }


            Console.ReadKey();
        }
    }
}

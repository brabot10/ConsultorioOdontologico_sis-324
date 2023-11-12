using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioOdontologico
{
    public class UsuarioCln
    {
        public static MySqlConnection conexion()
        {
            string servidor = "(localdb)\\MSSQLLocalDB";
            string puerto = "1433"; // Puerto MySQL
            string bd = "LabConsultorioOdontologico";
            string usuario = "usrconsultorio ";
            string password = "123456";

            string cadenaConexion = $"Server={servidor};Port={puerto};Database={bd};User Id={usuario};Password={password};";
            //string cadenaConexion = $"Server={servidor};Database={bd};User Id={usuario};Password={password};";
            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);

                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                return null;
            }
        }
    }
}

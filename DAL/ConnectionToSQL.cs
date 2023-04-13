using System.Data.SqlClient;
namespace DAL
{
    /*
    * Link al repositorio oficial de la BD:
    * https://github.com/GaboMartinezC/BD_ProyectoITrim
    * Contiene:
    * a.El diagrama lógico de la base de datos.
    * b.El script de creación de la base de datos.
    * c.El codigo fuente de los procedimientos almacenados escrito
    * en SQL para el motor de bases de datos MySQL para GNU/Linux (utilizable en
    * windows, solamente con MySQL).
    * c.Un archivo .bak que respalda la base de datos para SQL Server,
    * este archivo contiene en los ficheros de /Programmability/Stored Procedures
    * el código de los SP para SQL Server, así como el diagrama físico de la BD en el
    * fichero diagrams.
    * 
    * -Gabriel J.
    */
    public class ConnectionToSQL
    {
        private readonly string _connectionString;
        public ConnectionToSQL()
        {
            try
            {
                // !!!CAMBIAR SEGÚN LA COMPUTADORA!!!
                // Compu de Gabo: _connectionString = (@"Server=DESKTOP-9G4D1TG;Database=SISTEMALIBRERIA_EQUIPO211E;Trusted_Connection=true");
                // Compu 3 del laboratorio: _connectionString = (@"Server=DESKTOP-LQCGSEG;Database=SISTEMALIBRERIA_EQUIPO211E;Trusted_Connection=true");
                _connectionString = (@"Server=DESKTOP-LQCGSEG;Database=SISTEMALIBRERIA_EQUIPO211E;Trusted_Connection=true");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}

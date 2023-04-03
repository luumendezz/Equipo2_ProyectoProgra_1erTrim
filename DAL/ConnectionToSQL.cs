using System.Data.SqlClient;
namespace DAL
{
    public class ConnectionToSQL
    {
        private readonly string _connectionString;
        public ConnectionToSQL()
        {
            try
            {
                _connectionString = (@"Server=DESKTOP-9G4D1TG;Database=SISTEMALIBRERIA_EQUIPO211E;Trusted_Connection=true");
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

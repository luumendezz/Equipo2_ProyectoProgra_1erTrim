using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DetalleEntradaDAL : ConnectionToSQL
    {
        public bool IngresarDetallesCategoria(List<DetalleEntrada> ListaDetalles)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los detalles de Entrada 
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (DetalleEntrada de in ListaDetalles)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpIngresarDetalle", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            /*
                             * Parámetros
                             * Convierte de uint (Unsigned Integer) a Int para BD
                             * metodo Convert.ToInt32() [32 bits, entero estándar]
                             * Gabriel J.
                             */
                            cmd.Parameters.Add(new SqlParameter("@idEnt", Convert.ToInt32(de.IdEntrada)));
                            cmd.Parameters.Add(new SqlParameter("@idProdu", Convert.ToInt32(de.IdProducto)));
                            cmd.Parameters.Add(new SqlParameter("@cant", Convert.ToInt32(de.Cantidad)));
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Close();
                            retVal = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        retVal = false;
                    }
                }
            }
            return retVal;
        }
        public bool ActualizarDetallesCategoria(List<DetalleEntrada> ListaDetalles)
        {
            bool retVal = false;
            // Comentarios de metodo anterior
            foreach (DetalleEntrada de in ListaDetalles)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpActualizarDetalle", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@idEnt", Convert.ToInt32(de.IdEntrada)));
                            cmd.Parameters.Add(new SqlParameter("@idProdu", Convert.ToInt32(de.IdProducto)));
                            cmd.Parameters.Add(new SqlParameter("@cant", Convert.ToInt32(de.Cantidad)));
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Close();
                            retVal = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        retVal = false;
                    }
                }
            }
            return retVal;
        }
    }
}

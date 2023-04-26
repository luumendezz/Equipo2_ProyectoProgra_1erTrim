using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DetalleEntradaDAL : ConnectionToSQL
    {
        public bool IngresarDetalleEntrada(List<DetalleEntrada> ListaDetalles)
        {
            bool retVal = false;
            int ultimoIdEncabezado = this.UltimoIdEncabezado();
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
                             * -Convierte de uint (Unsigned Integer) a Int para BD
                             * metodo Convert.ToInt32() [32 bits, entero estándar]
                             * -ID de entrada es el ultimo ID registrado de un encabezado de entrada, 
                             * ver metodo privado hasta abajo de la clase
                             * Gabriel J.
                             */
                            cmd.Parameters.Add(new SqlParameter("@idEnt", ultimoIdEncabezado));
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
        // !!!! DEPRECADO, NO UTILIZAR !!!!
        /*public bool ActualizarDetalleEntrada(List<DetalleEntrada> ListaDetalles)
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
        }*/
        private int UltimoIdEncabezado()
        {
            int retVal = -1;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpUltimoIdEncabezado", cn))
                    {
                        DataTable dt = new DataTable();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        retVal = Convert.ToInt32(dt.Rows[0]["ID"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
        public DataTable VerTodoRegistroEntradas()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoEntradas", cn))
                    {
                        cmd.Connection = cn;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(retVal);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
    }
}

using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class EncabezadoEntradaDAL : ConnectionToSQL
    {
        public bool IngresarEntrada(EncabezadoEntrada encabezado)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarEncabezado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J. 
                         */
                        cmd.Parameters.Add(new SqlParameter("@idSuc", Convert.ToInt32(encabezado.IdSucursal)));
                        cmd.Parameters.Add(new SqlParameter("@idEmp", Convert.ToInt32(encabezado.IdEmpleado)));
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
            return retVal;
        }
        //!!!NO USAR DEPRECADO!!!
        public bool ActualizarEntrada(EncabezadoEntrada encabezado)
        {
            bool retVal = false; 
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpActualizarEncabezado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J.
                         */
                        cmd.Parameters.Add(new SqlParameter("@idEncabezado", Convert.ToInt32(encabezado.Id)));
                        cmd.Parameters.Add(new SqlParameter("@idSuc", Convert.ToInt32(encabezado.IdSucursal)));
                        cmd.Parameters.Add(new SqlParameter("@idEmp", Convert.ToInt32(encabezado.IdEmpleado)));
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
            return retVal;
        }
        public bool BorrarRegistroEntrada(int idEncabezado)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarEncabezado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idEncabezado", idEncabezado));
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
            return retVal;
        }
        /* !!PENDIENTE!! */
        public DataTable BuscarEntradasFecha(DateOnly fecha) 
        {
            DataTable retVal = new DataTable();
            return retVal;
        }
    }
}

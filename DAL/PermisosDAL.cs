using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class PermisosDAL : ConnectionToSQL
    {
        public bool IngresarPermisos(List<Permisos> ListaPermisos)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los permisos de un rol de usuario
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (Permisos p in ListaPermisos)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpIngresarPermisos", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@rol", Convert.ToInt32(p.IdRol)));
                            cmd.Parameters.Add(new SqlParameter("@idMod", Convert.ToInt32(p.IdModulo)));
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
        public bool ActualizarPermisos(List<Permisos> ListaPermisos)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los permisos de un rol de usuario
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (Permisos p in ListaPermisos)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpActualizarPermisos", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@rol", Convert.ToInt32(p.IdRol)));
                            cmd.Parameters.Add(new SqlParameter("@idMod", Convert.ToInt32(p.IdModulo)));
                            cmd.Parameters.Add(new SqlParameter("@idPerm", Convert.ToInt32(p.Id)));
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
        public bool BorrarPermiso(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarPermisos", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idPerm", id));
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
        public DataTable BuscarPermisoRol(int idRol)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarPermisosRol", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idRolUs", idRol));
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


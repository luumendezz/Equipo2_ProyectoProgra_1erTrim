using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class EmpleadoDAL : ConnectionToSQL
    {
        public bool IngresarEmpleado(Empleado empleado)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarAutor", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idCedula", empleado.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@nombre", empleado.NombreCompleto));
                        cmd.Parameters.Add(new SqlParameter("@contra", empleado.Contrasena));
                        cmd.Parameters.Add(new SqlParameter("@numero", empleado.NumeroTelefonico));
                        cmd.Parameters.Add(new SqlParameter("@email", empleado.Email));
                        //Entero sin signo -> Entero estándar 32 bits
                        cmd.Parameters.Add(new SqlParameter("@idRol", Convert.ToInt32(empleado.IdRol)));
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
        public bool ActualizarEmpleado(Empleado empleado)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpActualizarAutor", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Entero sin signo -> Entero estándar de 32 bits linea(s) 54 & 60
                        cmd.Parameters.Add(new SqlParameter("@idEmpleadoMod", Convert.ToInt32(empleado.Id)));
                        cmd.Parameters.Add(new SqlParameter("@idCedula", empleado.Cedula));
                        cmd.Parameters.Add(new SqlParameter("@nombre", empleado.NombreCompleto));
                        cmd.Parameters.Add(new SqlParameter("@contra", empleado.Contrasena));
                        cmd.Parameters.Add(new SqlParameter("@numero", empleado.NumeroTelefonico));
                        cmd.Parameters.Add(new SqlParameter("@email", empleado.Email));
                        cmd.Parameters.Add(new SqlParameter("@idRol", Convert.ToInt32(empleado.IdRol)));
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
        public bool InhabilitarEmpleado(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpInhabilitarCuentaEmpleado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idEmp", id));
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
        public DataTable BuscarTodos()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoEmpleado", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable BuscarEmpleado(string cedula)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarEmpleado", cn))
                    {
                        cmd.Connection = cn;
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Parameters.Add(new SqlParameter("@ced", cedula));
                        cmd.CommandType = CommandType.StoredProcedure;
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

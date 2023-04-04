using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class CategoriaDAL : ConnectionToSQL
    {
        public bool IngresarCategoria(Categoria categoria)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarCategoria", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descripcion", categoria.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@esGenero", categoria.EsGeneroLiterario));
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
        public bool ActualizarCategoria(Categoria categoria)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpActualizarCategoria", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descripcion", categoria.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@esGenero", categoria.EsGeneroLiterario));
                        cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(categoria.Id)));
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
        public bool BorrrarCategoria(int idCat)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarCategoria", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idCat", idCat));
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
        public DataTable BorrarCategoria(int idCat)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBusquedaTodoCategoria", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
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

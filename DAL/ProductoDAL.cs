using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class ProductoDAL : ConnectionToSQL
    {
        public bool IngresarProducto(Producto producto) 
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpIngresarProducto", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descrip", producto.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@stMinimo", Convert.ToInt32(producto.StockMinimo)));
                        cmd.Parameters.Add(new SqlParameter("@stMaximo", Convert.ToInt32(producto.StockMaximo)));
                        cmd.Parameters.Add(new SqlParameter("@idProv", Convert.ToInt32(producto.IdProveedor)));
                        cmd.Parameters.Add(new SqlParameter("@precioProd", producto.Precio));
                        cmd.Parameters.Add(new SqlParameter("@prodEstudiantil", producto.ProductoEstudiantil));
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
        public bool ActualizarProducto(Producto producto)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpActualizarProducto", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@descrip", producto.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@stMinimo", Convert.ToInt32(producto.StockMinimo)));
                        cmd.Parameters.Add(new SqlParameter("@stMaximo", Convert.ToInt32(producto.StockMaximo)));
                        cmd.Parameters.Add(new SqlParameter("@idProv", Convert.ToInt32(producto.IdProveedor)));
                        cmd.Parameters.Add(new SqlParameter("@precioProd", producto.Precio));
                        cmd.Parameters.Add(new SqlParameter("@prodEstudiantil", producto.ProductoEstudiantil));
                        cmd.Parameters.Add(new SqlParameter("@idProd", producto.Id));
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
        public bool BorrarProducto(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarProducto", cn))
                    {
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@idProd", id));
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
        public bool BuscarTodoProducto()
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoProducto", cn))
                    {
                        cmd.Connection = cn;
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
    }
}

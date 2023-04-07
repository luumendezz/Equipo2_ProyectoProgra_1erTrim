using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class ProductoDAL : ConnectionToSQL
    {
        /*
         * Gabriel J.
         * METODO I y II
         * Aplicables solo a Productos, no Libros.
         * Para más información ver en el repositorio oficial de la BD
         * SP_CRUDProducto.sql, comentario en línea 2
         */
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
        /*
         * Gabriel J.
         * Aplicable para borrado lógico de Libros y otro tipo de Productos
         * Ver SP_CRUDProducto.sql, Línea 90
         */
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
        //Selecciona los datos de producto, sin contar los libros
        public DataTable BuscarTodoProducto()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoProducto", cn))
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
        //Selecciona los datos de producto, contando los libros
        public DataTable BuscarTodoProductoGeneral()
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarTodoProductoGeneral", cn))
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
        //Busca todos los productos dados un id de proveedor
        public DataTable BuscarProductoProveedor(int id)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarProductoProveedor", cn))
                    {
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@idProv", id));
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
        //Busca cualquier tipo de producto según un id
        public DataTable BuscarProducto(int id)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarProducto", cn))
                    {
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@idProd", id));
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

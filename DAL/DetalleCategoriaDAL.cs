using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DetalleCategoriaDAL : ConnectionToSQL
    {
        
        public bool IngresarDetallesCategoria(List<DetalleCategoria> ListaCategorias)
        {
            bool retVal = false;
            /*
             * Gabriel J.
             * Recibe una lista con todos los detalles de Categoria de un producto
             * Los va ingresando a la base de datos con un foreach de cada objeto en la lista
             */
            foreach (DetalleCategoria dc in ListaCategorias)
            {
                using (var cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (var cmd = new SqlCommand("SpIngresarDetalleCategoria", cn))
                        {
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@idProd", Convert.ToInt32(dc.IdProducto)));
                            cmd.Parameters.Add(new SqlParameter("@idCat", Convert.ToInt32(dc.IdCategoria)));
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
        //Borra únicamente un detalle
        public bool BorrarDetalle(int id)
        {
            bool retVal = false;
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBorrarDetalleCategoria", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idDet", id));
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
        //Busca las categorías asociadas a un producto dado un ID
        public DataTable BuscarCategoriasProducto(int idProd)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarCategoriasProducto", cn))
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idProd", idProd));
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

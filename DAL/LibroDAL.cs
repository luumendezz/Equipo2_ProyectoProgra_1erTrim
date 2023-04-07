using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class LibroDAL : ConnectionToSQL
    {
        public bool IngresarLibro(Libro libro)
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
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J.
                         */
                        cmd.Parameters.Add(new SqlParameter("@descrip", libro.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@stMinimo", Convert.ToInt32(libro.StockMinimo)));
                        cmd.Parameters.Add(new SqlParameter("@stMaximo", Convert.ToInt32(libro.StockMaximo)));
                        cmd.Parameters.Add(new SqlParameter("@idProv", Convert.ToInt32(libro.IdProveedor)));
                        cmd.Parameters.Add(new SqlParameter("@precioProd", libro.Precio));
                        cmd.Parameters.Add(new SqlParameter("@prodEstudiantil", libro.ProductoEstudiantil));
                        cmd.Parameters.Add(new SqlParameter("@cantPag", Convert.ToInt32(libro.CantidadPaginas)));
                        cmd.Parameters.Add(new SqlParameter("@idAut", Convert.ToInt32(libro.IdAutor)));
                        cmd.Parameters.Add(new SqlParameter("@idIdi", Convert.ToInt32(libro.IdIdioma)));
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
        public bool ActualizarLibro(Libro libro)
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
                        /*
                         * Parámetros
                         * Convierte de uint (Unsigned Integer) a Int para BD
                         * metodo Convert.ToInt32() [32 bits, entero estándar]
                         * Gabriel J.
                         */
                        cmd.Parameters.Add(new SqlParameter("@descrip", libro.Descripcion));
                        cmd.Parameters.Add(new SqlParameter("@stMinimo", Convert.ToInt32(libro.StockMinimo)));
                        cmd.Parameters.Add(new SqlParameter("@stMaximo", Convert.ToInt32(libro.StockMaximo)));
                        cmd.Parameters.Add(new SqlParameter("@idProv", Convert.ToInt32(libro.IdProveedor)));
                        cmd.Parameters.Add(new SqlParameter("@precioProd", libro.Precio));
                        cmd.Parameters.Add(new SqlParameter("@prodEstudiantil", libro.ProductoEstudiantil));
                        cmd.Parameters.Add(new SqlParameter("@cantPag", Convert.ToInt32(libro.CantidadPaginas)));
                        cmd.Parameters.Add(new SqlParameter("@idAut", Convert.ToInt32(libro.IdAutor)));
                        cmd.Parameters.Add(new SqlParameter("@idIdi", Convert.ToInt32(libro.IdIdioma)));
                        cmd.Parameters.Add(new SqlParameter("@idLib", Convert.ToInt32(libro.Id)));
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
        //Busca los libros en cierto idioma
        public DataTable BuscarLibroIdioma(int idIdi)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarLibroIdioma", cn))
                    {
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@idIdi", idIdi));
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
        //Busca los libros de un autor
        public DataTable BuscarLibroAutor(int idAut)
        {
            DataTable retVal = new DataTable();
            using (var cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (var cmd = new SqlCommand("SpBuscarLibroAutor", cn))
                    {
                        cmd.Connection = cn;
                        cmd.Parameters.Add(new SqlParameter("@idAut", idAut));
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

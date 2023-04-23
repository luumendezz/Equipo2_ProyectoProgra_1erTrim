using ET;
using DAL;
using System.Data;

namespace BL
{
    public class LibroBL : ProductoBL
    {
        private LibroDAL dal = new LibroDAL();
        public bool IngresarLibro(Libro libro)
        {
            //Valor de retorno
            bool retVal = true,
            //Variable bandera que define si el proveedor del libro es una editorial
            //ver metodo protegido en la superclase producto de la que esta hereda
            esEditorial = ProveedorEsEditorial(libro.IdProveedor);
            //Si el proveedor del libro no es una editorial o si el stock
            //máximo del libro es menor al mínimo, retorna un falso
            if (!esEditorial || libro.StockMaximo < libro.StockMinimo) 
                retVal = false;
            //Si no, el valor de retorno es lo que retorne el método de ingreso
            else
                retVal = dal.IngresarLibro(libro);
            return retVal;
        }
        public bool ActualizarLibro(Libro libro)
        {
            //Ver comentarios del método anterior para más información
            bool retVal = true,
            esEditorial = ProveedorEsEditorial(libro.IdProveedor);
            if (!esEditorial || libro.StockMaximo < libro.StockMinimo)
                retVal = false;
            else
                retVal = dal.ActualizarLibro(libro);
            return retVal;
        }
        public DataTable BuscarLibroIdioma(int idIdi)
        {
            return dal.BuscarLibroIdioma(idIdi);
        }
        public DataTable BuscarLibroAutor(int idAut)
        {
            return dal.BuscarLibroAutor(idAut);
        }

    }
}

using DAL;
using ET;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BL
{
    public class AutorBL
    {
        AutorDAL dal = new AutorDAL();
        public bool IngresarAutor(Autor autor)
        {
            /* Instancia dos Datatable que buscan el nombre y apellido en DAL */
            DataTable validacionNombre = dal.BuscarAutorNombre(autor.Nombre);
            DataTable validacionApellido = dal.BuscarAutorApellido(autor.Apellidos);
            /*
             * Busca en el atributo Rows (Filas) el valor
             * En caso de que esto sea 0, significa que no hay resultados
             * Si no hay resultados, se puede guardar, entonces llama al DAL y retorna verdadero
             * Si existen resultados en las busquedas, retorna un falso
             * FIXME
             */
            if (validacionNombre.Rows.Count == 0 || validacionApellido.Rows.Count == 0)
            {
                dal.IngresarAutor(autor);
                return true;
            }
            else
                return false;
        }
        public bool ActualizarAutor(Autor autor)
        {
            return dal.ActualizarAutor(autor);
        }
        public bool BorrarAutor(int idAut)
        {
            return dal.BorrarAutor(idAut);
        }
        public DataTable BuscarAutorNombre(string nombre) 
        {
            return dal.BuscarAutorNombre(nombre);
        }
        public DataTable BuscarAutorApellido(string apellido)
        {
            return dal.BuscarAutorApellido(apellido);
        }
    }
}

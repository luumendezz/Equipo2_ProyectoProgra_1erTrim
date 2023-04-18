using DAL;
using ET;
using System.Data;

namespace BL
{
    public class AutorBL
    {
        private AutorDAL dal = new AutorDAL();
        public bool IngresarAutor(Autor autor)
        {
            //Valor de retorno
            bool retVal = true;
            /* Instancia una datatable que se llena con los datos existentes en BD */
            DataTable listaAutores = dal.BuscarTodos();
            //Variable temporal que guarda los datos a validar
            //Funciones únicamente de legibilidad, puede ser omitida
            string descripcion = "";
            for(int i = 0; i < listaAutores.Rows.Count; i++) 
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = listaAutores.Rows[i]["NOMBRE"].ToString();
                //Compara nombre y apellido
                if (autor.Nombre.Equals(descripcion))
                    retVal = false;
                descripcion = listaAutores.Rows[i]["APELLIDOS"].ToString();
                if (autor.Apellidos.Equals(descripcion))
                    retVal = false;                
            }
            //Si no se encontró, lo que significaría que el valor de retorno es verdadero
            //registra el dato y retorna el verdadero (a menos que exista una excepción), si no, solo retorna el falso
            if (retVal)
                retVal = dal.IngresarAutor(autor);
            return retVal;
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

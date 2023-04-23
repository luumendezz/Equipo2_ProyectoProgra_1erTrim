using DAL;
using ET;
using System.Data;

namespace BL
{
    public class IdiomaBL
    {
        private IdiomaDAL dal = new IdiomaDAL();
        public bool IngresarIdioma(Idioma idioma)
        {
            //Valor de retorno
            bool retVal = true;
            //Busca todos los idiomas disponibles en BD
            DataTable consultaIdiomas = dal.BuscarTodoIdioma();
            //Variable temporal que guarda las descripciones de idioma
            //Funciones únicamente de legibilidad, puede ser omitida
            string descripcion = "";
            //Lleva toda la descripcion de idioma a minúsculas
            idioma.Descripcion = idioma.Descripcion.ToLower();
            //recorre la base de datos en busca de la descripción de idioma
            for (int i = 0; i < consultaIdiomas.Rows.Count; i++)
            {
                //Llena la string de descripcion con la consulta y la compara con el nuevo registro
                //Si este se encuentra, el valor de retorno es falso
                descripcion = consultaIdiomas.Rows[i]["DESCRIPCION"].ToString();
                if (descripcion.Equals(idioma.Descripcion))
                {
                    retVal = false;
                    //Finaliza el ciclo
                    break;
                }
            }
            //Si no se encontró, lo que significaría que el valor de retorno es verdadero
            //registra el dato y retorna el verdadero, si no, solo retorna el falso
            if (retVal)
                retVal = dal.IngresarIdioma(idioma);
            return retVal;
        }
        public bool ActualizarIdioma(Idioma idioma)
        {
            return dal.ActualizarIdioma(idioma);
        }
        public bool BorrarIdioma(int id)
        {
            return dal.BorrarIdioma(id);
        }
        public DataTable BuscarTodoIdioma() 
        {
            return dal.BuscarTodoIdioma();
        }
    }
}

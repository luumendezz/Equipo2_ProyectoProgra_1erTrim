using ET;
using DAL;
using System.Data;
namespace BL
{
    public class EmpleadoBL
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public Empleado BuscarEmpleado(string cedula)
        {
            //Instancia una entidad empleado
            Empleado empleado = new Empleado();
            //Instancia una datatable y después la llena con una consulta
            //donde se busca la cedula del empleado
            DataTable dtEmpleado = new DataTable();
            dtEmpleado = dal.BuscarEmpleado(cedula);
            //Si la propiedad count de las columnas de la datatable es mayor a 0 
            //significa que el query fue correcto
            if (dtEmpleado.Rows.Count == 0)
            {
                //El id de rol de la entidad es el id de rol de la BD
                //La contraseña igual se devuelve para ser validada
                empleado.IdRol = Convert.ToUInt32(dtEmpleado.Rows[0]["ID_ROL"].ToString());
                empleado.Contrasena = dtEmpleado.Rows[0]["CONTRASENA"].ToString();
            }
            //Si no devuelve nada, devuelve el id en 0
            else
                empleado.Id = 0;
            return empleado;
        }
    }
}

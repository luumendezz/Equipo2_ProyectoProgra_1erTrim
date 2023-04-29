using ET;
using DAL;
using System.Data;
namespace BL
{
    public class EmpleadoBL
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public uint BuscarEmpleado(string cedula, string contrasena)
        {
            return dal.BuscarEmpleado(cedula, contrasena);
        }
    }
}
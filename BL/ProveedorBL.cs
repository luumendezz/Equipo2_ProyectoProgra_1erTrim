using ET;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class ProveedorBL
    {
        ProveedorDAL dal = new ProveedorDAL();

        public bool IngresarProveedor(Proveedor proveedor)
        {
            return dal.IngresarProveedor(proveedor);
        }
        public bool ActualizarProveedor(Proveedor proveedor)
        {
            return dal.ActualizarProveedor(proveedor);
        }
        public bool BorrarProveedor(int id)
        {
            return dal.BorrarProveedor(id);
        }
        public DataTable BuscarTodo()
        {
            return dal.BuscarTodo();
        }
        public DataTable BuscarProveedor(int id)
        {
            return dal.BuscarProveedor(id);
        }
    }
}

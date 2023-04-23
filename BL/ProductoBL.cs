using ET;
using DAL;
using System.Data;

namespace BL
{
    public class ProductoBL
    {
        private ProductoDAL dal = new ProductoDAL();
        public bool IngresarProducto(Producto producto)
        {
            bool retVal = true;
            //Valida lógicamente que el stock máximo no sea menor al mínimo
            if (producto.StockMaximo < producto.StockMinimo)
                retVal = false;
           //Si el proveedor es una editorial, al pertenecer a superclase producto
           //retorna un falso
            if (ProveedorEsEditorial(producto.IdProveedor))
                retVal = false;
            //Si ninguna de las condicionales anteriores se cumple, ingresa el producto
            //y retorna lo que retorne el método el DAL
            if (retVal)
                retVal = dal.IngresarProducto(producto);
            return retVal;
        }
        public bool ActualizarProducto(Producto producto)
        {
            //Ver comentarios del método de ingreso para más información
            bool retVal = true;
            if (producto.StockMaximo < producto.StockMinimo)
                retVal = false;
            if (ProveedorEsEditorial(producto.IdProveedor))
                retVal = false;
            if (retVal)
                retVal = dal.ActualizarProducto(producto);
            return retVal;
        }
        //Metodo protegido que se utiliza en esta clase y en la clase hijo 'producto'
        protected bool ProveedorEsEditorial(uint idProv)
        {
            /*
             * Se debe, por regla de negocio, validar que el proveedor 
             * no sea una editorial, pudiendo estas ser únicamente proveedoras
             * de productos de clase libro, o en caso contrario, un libro no puede no tener
             * un proveedor de tipo editorial
             * Gabriel J.
             */
            bool retVal = true;
            uint idCicloProv = 0;
            //Instancia el dal de proveedor y una tabla con los proveedores a analizar
            ProveedorDAL dalProv = new ProveedorDAL();
            DataTable proveedores = dalProv.BuscarTodo();
            //Recorre la datatable en busqueda del ID de proveedor
            for (int i = 0; i < proveedores.Rows.Count; i++)
            {
                //Convierte el id del proveedor en un entero sin signo
                idCicloProv = Convert.ToUInt32(proveedores.Rows[i]["ID"]);
                //Compara el id de proveedor enviado por parámetros con el que se está buscando
                if (idCicloProv == idProv)
                {
                    //Convierte el dato booleano de la datatable al valor de retorno
                    retVal = Convert.ToBoolean(proveedores.Rows[i]["ES_EDITORIAL"]);
                    //Finaliza el ciclo
                    break;
                }
                
            }
            return retVal;
        }
        public bool BorrarProducto(int id)
        {
            return dal.BorrarProducto(id);
        }
        public DataTable BuscarTodoProducto() 
        {
            return dal.BuscarTodoProducto();
        }
        public DataTable BuscarTodoProductoGeneral()
        {
            return dal.BuscarTodoProductoGeneral();
        }
        public DataTable BuscarProducto(string descrip)
        {
            return dal.BuscarProducto(descrip);
        }
        public DataTable BuscarProductoProveedor(int idProv)
        {
            return dal.BuscarProductoProveedor(idProv);
        }
    }
}
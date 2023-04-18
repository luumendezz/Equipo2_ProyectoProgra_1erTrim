using ET;
using DAL;
using System.Data;

namespace BL
{
    public class ProductoBL
    {
        private ProductoDAL dal = new ProductoDAL();
        public bool Ingresar(Producto producto)
        {
            return dal.IngresarProducto(producto);
        }

        
    }
}
namespace ET
{
    public class Producto
    {
        protected uint id;
        protected uint idProveedor;
        protected uint stockMaximo;
        protected uint stockMinimo;
        protected string descripcion;
        protected double precio;
        protected bool productoEstudiantil;

        private uint Id { get => id; set => id = value; }
        private uint IdProveedor { get => idProveedor; set => idProveedor = value; }
        private uint StockMaximo { get => stockMaximo; set => stockMaximo = value; }
        private uint StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        private string Descripcion { get => descripcion; set => descripcion = value; }
        private double Precio { get => precio; set => precio = value; }
        private bool ProductoEstudiantil { get => productoEstudiantil; set => productoEstudiantil = value; }
    }
}

namespace ET
{
    public class Producto
    {
        protected uint id;
        protected uint idProveedor;
        protected uint stockMaximo;
        protected uint stockMinimo;
        protected string descripcion;
        protected float precio;
        protected bool productoEstudiantil;

        public uint Id { get => id; set => id = value; }
        public uint IdProveedor { get => idProveedor; set => idProveedor = value; }
        public uint StockMaximo { get => stockMaximo; set => stockMaximo = value; }
        public uint StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public bool ProductoEstudiantil { get => productoEstudiantil; set => productoEstudiantil = value; }
    }
}

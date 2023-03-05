namespace ET
{
    public class Bodega
    {
        private uint id;
        private uint idProducto;
        private uint idSucursal;
        private uint cantidad;

        public uint Id { get => id; set => id = value; }
        public uint IdProducto { get => idProducto; set => idProducto = value; }
        public uint IdSucursal { get => idSucursal; set => idSucursal = value; }
        public uint Cantidad { get => cantidad; set => cantidad = value; }
    }
}

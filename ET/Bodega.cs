namespace ET
{
    public class Bodega
    {
        private uint _id;
        private uint _idProducto;
        private uint _idSucursal;
        private uint _cantidad;

        public uint Id { get => _id; set => _id = value; }
        public uint IdProducto { get => _idProducto; set => _idProducto = value; }
        public uint IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public uint Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}

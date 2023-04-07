namespace ET
{
    public class DetalleEntrada
    {
        private uint _id;
        private uint _idEntrada;
        private uint _idProducto;
        private uint _cantidad;

        public uint Id { get => _id; set => _id = value; }
        public uint IdEntrada { get => _idEntrada; set => _idEntrada = value; }
        public uint IdProducto { get => _idProducto; set => _idProducto = value; }
        public uint Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}

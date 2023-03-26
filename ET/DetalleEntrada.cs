namespace ET
{
    public class DetalleEntrada
    {
        private uint _id;
        private uint _idEntrada;
        private uint _idProducto;
        private uint _idCantidad;

        public uint Id { get => _id; set => _id = value; }
        public uint IdEntrada { get => _idEntrada; set => _idEntrada = value; }
        public uint IdProducto { get => _idProducto; set => _idProducto = value; }
        public uint IdCantidad { get => _idCantidad; set => _idCantidad = value; }
    }
}

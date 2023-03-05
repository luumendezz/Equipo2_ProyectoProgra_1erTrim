namespace ET
{
    public class DetalleEntrada
    {
        private uint id;
        private uint idEntrada;
        private uint idProducto;
        private uint idCantidad;

        public uint Id { get => id; set => id = value; }
        public uint IdEntrada { get => idEntrada; set => idEntrada = value; }
        public uint IdProducto { get => idProducto; set => idProducto = value; }
        public uint IdCantidad { get => idCantidad; set => idCantidad = value; }
    }
}

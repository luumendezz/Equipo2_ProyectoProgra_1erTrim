using System.ComponentModel.DataAnnotations;

namespace ET
{
    public class DetalleCategoria
    {
        private uint _id;
        private uint _idProducto;
        private uint _idCategoria;

        public uint Id { get => _id; set => _id = value; }
        public uint IdProducto { get => _idProducto; set => _idProducto = value; }
        public uint IdCategoria { get => _idCategoria; set => _idCategoria = value; }
    }
}

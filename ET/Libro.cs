namespace ET
{
    public class Libro : Producto
    {
        private uint _idAutor;
        private uint _idIdioma;
        private uint _cantidadPaginas;

        public uint IdAutor { get => _idAutor; set => _idAutor = value; }
        public uint IdIdioma { get => _idIdioma; set => _idIdioma = value; }
        public uint CantidadPaginas { get => _cantidadPaginas; set => _cantidadPaginas = value; }
    }
}

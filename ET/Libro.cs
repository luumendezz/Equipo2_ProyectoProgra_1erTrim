namespace ET
{
    public class Libro : Producto
    {
        private uint idAutor;
        private uint idIdioma;
        private uint cantidadPaginas;

        public uint IdAutor { get => idAutor; set => idAutor = value; }
        public uint IdIdioma { get => idIdioma; set => idIdioma = value; }
        public uint CantidadPaginas { get => cantidadPaginas; set => cantidadPaginas = value; }
    }
}

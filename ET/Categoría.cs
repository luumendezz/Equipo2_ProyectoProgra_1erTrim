namespace ET
{
    public class Categoría
    {
        private uint id;
        private string descripcion;
        private bool esGeneroLiterario;

        public uint Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool EsGeneroLiterario { get => esGeneroLiterario; set => esGeneroLiterario = value; }
    }
}

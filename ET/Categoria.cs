namespace ET
{
    public class Categoria
    {
        private uint _id;
        private string _descripcion;
        private bool _esGeneroLiterario;

        public uint Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool EsGeneroLiterario { get => _esGeneroLiterario; set => _esGeneroLiterario = value; }
    }
}

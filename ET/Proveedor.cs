namespace ET
{
    public class Proveedor
    {
        private uint _id;
        private string _descripcion;
        private bool _esEditorial;
        private string _email;
        private string _telefono;

        public uint Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool EsEditorial { get => _esEditorial; set => _esEditorial = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
    }
}

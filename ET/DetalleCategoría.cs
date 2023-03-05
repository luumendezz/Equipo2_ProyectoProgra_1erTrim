using System.ComponentModel.DataAnnotations;

namespace ET
{
    public class DetalleCategoría
    {
        private uint id;
        private string descripcion;
        private bool esEditorial;
        private string email;
        private string telefono;

        public uint Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool EsEditorial { get => esEditorial; set => esEditorial = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}

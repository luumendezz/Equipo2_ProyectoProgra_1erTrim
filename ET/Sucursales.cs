namespace ET
{
    public class Sucursales
    {
        private uint _id;
        private string _ubicacion;
        private string _numeroTelefonico;

        public uint Id { get => _id; set => _id = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string NumeroTelefonico { get => _numeroTelefonico; set => _numeroTelefonico = value; }
    }
}

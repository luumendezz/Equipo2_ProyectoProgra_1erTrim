namespace ET
{
    public class Autor
    {
        private uint _id;
        private string _nombre;
        private string _apellidos;

        public uint Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
    }
}

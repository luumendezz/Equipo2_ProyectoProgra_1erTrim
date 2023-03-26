namespace ET
{
    public class Empleado
    {
        private uint _id;
        private string _cedula;
        private string _nombreCompleto;
        private string _contrasena;
        private string _numeroTelefonico;
        private string _email;
        private uint _idRol;
        private bool _empleadoVigente;

        public uint Id { get => _id; set => _id = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string NumeroTelefonico { get => _numeroTelefonico; set => _numeroTelefonico = value; }
        public string Email { get => _email; set => _email = value; }
        public uint IdRol { get => _idRol; set => _idRol = value; }
        public bool EmpleadoVigente { get => _empleadoVigente; set => _empleadoVigente = value; }
    }
}
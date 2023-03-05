namespace ET
{
    public class Empleado
    {
        private uint id;
        private string cedula;
        private string nombreCompleto;
        private string contrasena;
        private string numeroTelefonico;
        private string email;
        private uint idRol;
        private bool empleadoVigente;

        public uint Id { get => id; set => id = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        public string Email { get => email; set => email = value; }
        public uint IdRol { get => idRol; set => idRol = value; }
        public bool EmpleadoVigente { get => empleadoVigente; set => empleadoVigente = value; }
    }
}
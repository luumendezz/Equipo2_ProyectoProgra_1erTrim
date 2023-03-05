namespace ET
{
    public class EncabezadoEntrada
    {
        private uint id;
        private uint idSucursal;
        private uint idEmpleado;
        private string fecha;

        public uint Id { get => id; set => id = value; }
        public uint IdSucursal { get => idSucursal; set => idSucursal = value; }
        public uint IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}

namespace ET
{
    public class EncabezadoEntrada
    {
        private uint _id;
        private uint _idSucursal;
        private uint _idEmpleado;
        private string _fecha;

        public uint Id { get => _id; set => _id = value; }
        public uint IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public uint IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
    }
}

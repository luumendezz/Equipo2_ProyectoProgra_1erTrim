namespace ET
{
    public class EncabezadoEntrada
    {
        private uint _id;
        private uint _idSucursal;
        private uint _idEmpleado;
        private DateOnly _fecha;

        public uint Id { get => _id; set => _id = value; }
        public uint IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public uint IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public DateOnly Fecha { get => _fecha; set => _fecha = value; }
    }
}

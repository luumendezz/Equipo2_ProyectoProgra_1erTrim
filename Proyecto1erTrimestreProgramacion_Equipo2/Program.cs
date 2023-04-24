using ET;
using BL;
using DAL;

namespace Proyecto1erTrimestreProgramacion_Equipo2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            /* Probar el DAL desde aquí
             * Borrar el using DAL; cuando se termine de probar
            */
            DetalleEntrada d1 = new DetalleEntrada();
            d1.IdEntrada = 3;
            d1.Cantidad = 300;
            d1.IdProducto = 1;
            DetalleEntrada d2 = new DetalleEntrada();
            d2.IdEntrada = 1;
            d2.Cantidad = 20;
            d2.IdProducto = 2;
            List<DetalleEntrada> ls = new List<DetalleEntrada>();
            ls.Add(d1);
            ls.Add(d2);
            DetalleEntradaBL bl = new DetalleEntradaBL();
            if (bl.IngresarDetalleEntrada(ls, 1))
                MessageBox.Show("Sirve");
            else
                MessageBox.Show("No sirve");
        }
    }
}
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
            Producto p = new Producto();
            p.Descripcion = "Prod 1";
            p.Precio = 100;
            p.StockMinimo = 1;
            p.StockMaximo = 100;
            p.IdProveedor = 1;
            p.ProductoEstudiantil = false;
            ProductoBL bl = new ProductoBL();
            if (bl.IngresarProducto(p))
                MessageBox.Show("Sirve");
            else
                MessageBox.Show("No sirve");
        }
    }
}
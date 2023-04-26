using ET;
using BL;
using DAL;
using System.Data;

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
            Bodega b = new Bodega();
            b.IdProducto = 1;
            b.IdSucursal = 1;
            int un = 1;
            BodegaDAL bodegaDAL = new BodegaDAL();
            ProductoDAL dal = new ProductoDAL();
            MessageBox.Show("21");
            DataTable dataTable = bodegaDAL.VerBodega(un);
            MessageBox.Show(dataTable.Rows.Count + "");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                MessageBox.Show(dataTable.Rows[i]["CANTIDAD"] + "");
            }
            MessageBox.Show("control2");
            /*
            DetalleEntrada d1 = new DetalleEntrada();
            d1.IdEntrada = 1;
            d1.Cantidad = 300;
            d1.IdProducto = 1;
            /*DetalleEntrada d2 = new DetalleEntrada();
            d2.IdEntrada = 1;
            d2.Cantidad = 20;
            d2.IdProducto = 2;
            List<DetalleEntrada> ls = new List<DetalleEntrada>();
            ls.Add(d1);
            DetalleEntradaBL bl = new DetalleEntradaBL();
            if (bl.IngresarDetalleEntrada(ls, 1))
                MessageBox.Show("Sirve");
            else
                MessageBox.Show("No sirve");
            */
        }
    }
}
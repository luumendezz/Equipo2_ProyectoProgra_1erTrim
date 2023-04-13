using ET;
using BL;

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
            DetalleCategoria dc1 = new DetalleCategoria();
            dc1.IdProducto = 2;
            dc1.IdCategoria = 3;
            DetalleCategoria dc2 = new DetalleCategoria();
            dc2.IdProducto = 2;
            dc2.IdCategoria = 4;
            DetalleCategoria dc3 = new DetalleCategoria();
            dc3.IdProducto = 2;
            dc3.IdCategoria = 2;
            List<DetalleCategoria> lc = new List<DetalleCategoria>();
            lc.Add(dc1);
            lc.Add(dc2);
            lc.Add(dc3);
            bl.Prueba(lc);
        }
    }
}
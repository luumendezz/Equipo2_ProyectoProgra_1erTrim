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
            ApplicationConfiguration.Initialize();
            Application.Run(new GUI.Principal());

            /* Probar el DAL desde aquí
             * Borrar el using DAL; cuando se termine de probar
            
            EmpleadoBL bl = new EmpleadoBL();
            string ced = "119690990";
            if (bl.BuscarEmpleado(ced,"123") != 0)
                MessageBox.Show("Sirve");
            else
                MessageBox.Show("No sirve");*/
        }
    }
}
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
            Autor autor = new Autor();
            autor.Nombre = "Gabriel";
            autor.Apellidos = "Martinez";
            AutorBL bl = new AutorBL();
            if (!bl.BorrarAutor(21))
              MessageBox.Show("Funciona");
        }
    }
}
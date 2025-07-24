using WinModuloNomina.Vista;

namespace WinModuloNomina
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

<<<<<<< HEAD
            //Application.Run(new LoginForm());

            Application.Run(new LoginForm());
=======
            Application.Run(new MenuPrincipal());
>>>>>>> af800a64825d1148f5ef0276b74bf42bbf0b1935

        }
    }
}
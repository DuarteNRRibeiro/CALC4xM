using System;

namespace Calc4xMApp
{
    internal static class Calc4xMApp
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    }
}
namespace Calc4xM
{
    internal static class Calc4xM
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
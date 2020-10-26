using System;
using System.Threading;
using System.Windows.Forms;

namespace Doxie.HelpFileGenerator.GUI
{
    static class Globals
    {
        public static string errorMsg;
        public static int counter;
        public static string extended_description;
    }
    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.Run(new MainForm());
        }
        /// <summary>
        /// Global exceptions in Non User Interface(other thread) anticipated error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("{0}\r\n" + "{1}\r\n", ((Exception)e.ExceptionObject).Message, ((Exception)e.ExceptionObject).StackTrace);
            if (Globals.errorMsg == null) { Globals.errorMsg = message; } else { Globals.errorMsg += "\r\n" + message; }
            CustomMessageBox.Show(Globals.errorMsg);
        }

        /// <summary>
        /// Global exceptions in User Interface anticipated error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = String.Format("{0}\r\n" + "{1}\r\n", e.Exception.Message, e.Exception.StackTrace);
            if (Globals.errorMsg == null) { Globals.errorMsg = message; } else { Globals.errorMsg += "\r\n" + message; }
            CustomMessageBox.Show(Globals.errorMsg);
        }
    }
}
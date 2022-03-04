using System;

namespace FastfoodOrderingSystem
{
    internal static class MasterClass
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello start!~");
            ApplicationConfiguration.Initialize();
            Application.Run(new FFOS_UI());

            
            Console.WriteLine("Hello there!~");
        }
    }
}
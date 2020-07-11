using System;

namespace PurchasingAnalyzer.Wpf
{
    public static class Startup
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var client = new Client();
            client.Run();
        }
    }
}

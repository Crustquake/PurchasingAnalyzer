using System;
using System.Windows;

namespace PurchasingAnalyzer.Wpf
{
    internal class Client
    {
        public void Run()
        {
            try
            {
                Window mainWindow = new MainWindow();
                Application application = new Application();
                application.Run(mainWindow);
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }
        }

        private void HandleException(Exception exception)
        {
            MessageBox.Show($"Fatal error with reason: {exception.Message}. Please look log file", "Fatal error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

﻿using System.Windows;

namespace UiDesignTinkering
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };
            mainWindow.Show();
        }
    }
}

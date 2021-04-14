using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void Change_Language(string lang)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            var old_window = Current.MainWindow;
            var old_window_x = old_window.Top;
            var old_window_y = old_window.Left;

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Top = old_window_x;
            Current.MainWindow.Left = old_window_y;
            Current.MainWindow.Show();
            old_window.Close();
        }
    }
}

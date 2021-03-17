using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{name_text_box.Text}");
        }

        private void age_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            age_text_block.Text = age_slider.Value.ToString();
        }

        private void weight_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            weight_text_block.Text = weight_slider.Value.ToString();
        }
    }
}

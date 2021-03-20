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
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string file = "repo.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void age_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var r = age_slider.Value % 10;

            age_text_block.Text = age_slider.Value.ToString();

            if (r == 2 || r == 3 || r == 4)
            {
                age_text_block.Text += " lata";
            }
            else
            {
                age_text_block.Text += " lat";
            }
        }

        private void weight_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            weight_text_block.Text = weight_slider.Value + " kg";
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            int height;

            if (int.TryParse(height_text_box.Text, out height)) // Zmienna height posiada juz wartość z formularza 'out height'
            {
                if (name_text_box.Text != "" & surname_text_box.Text != "")
                {
                    Player player = new Player(name_text_box.Text, surname_text_box.Text, (int)age_slider.Value, (int)weight_slider.Value, height, club_combo_box.Text);
                    bool not_exists = true;

                    foreach (Player i in players_list_box.Items)
                    {
                        if (i.Name == player.Name && i.Surname == player.Surname && i.Age == player.Age)
                        {
                            not_exists = false;
                            break;
                        }
                    }

                    if (not_exists)
                    {
                        players_list_box.Items.Add(player);
                        clearForm();
                    }
                    else MessageBox.Show("Piłkarz znajduję się już na liście");
                }
            }
            else
            {
                MessageBox.Show("Wzrost zawiera błędne dane");
            }
        }

        public void clearForm()
        {
            name_text_box.Text = "";
            surname_text_box.Text = "";
            height_text_box.Text = "";
            age_slider.Value = age_slider.Minimum;
            weight_slider.Value = weight_slider.Minimum;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Player p in players_list_box.Items)
            {
                File.AppendAllText(file, p.ToString() + Environment.NewLine);
            }
        }
    }
}

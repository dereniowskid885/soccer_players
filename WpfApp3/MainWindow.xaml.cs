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
        private ObservableCollection<Student> listaStudentow = new ObservableCollection<Student>();

        public MainWindow()
        {
            InitializeComponent();

            listaStudentow.Add(new Student("Janusz", "Nowak"));
            listaStudentow.Add(new Student("Krzysztof", "Piątek"));

            listBox_studenci.ItemsSource = listaStudentow;
        }

        private void TextBox_ZmianaTekstu(object sender, TextChangedEventArgs e)
        {
            poleTekstowe.Text = ((TextBox)sender).Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(tb_imie.Text, tb_nazwisko.Text);
            //listBox_studenci.Items.Add(student);
            listaStudentow.Add(student);
        }
    }
}

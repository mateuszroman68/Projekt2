using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        List<Killer> listOfKillers = new List<Killer>();
        Killer killer;

        public MainWindow()
        {
            InitializeComponent();
            if(File.Exists("D://test.xml"))
            {
                listOfKillers = Serializacja.DeserializeToObject<List<Killer>>("D://test.xml");

            }
            else
            {
                listOfKillers.Add(new Killer("Mat","Roman","Roman","Polska","0","2000-"));

            }
            killer = new Killer();
            this.DataContext = killer;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfKillers.Add(new Killer(killer));
            killer = new Killer();
            this.DataContext = killer;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lista okno = new Lista();
            okno.lvUsers.ItemsSource = listOfKillers;
            okno.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Serializacja.SerializeToXml<List<Killer>>(listOfKillers, "D://test.xml");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
               zdjecie.Source = new BitmapImage(fileUri);
            }
        }

        
    }
}

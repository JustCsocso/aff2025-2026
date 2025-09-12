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
using System.Windows.Shapes;

namespace Fuggohidak
{
    /// <summary>
    /// Interaction logic for win2.xaml
    /// </summary>
    public partial class win2 : Window
    {
        public win2()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        List<Fuggohid> adatok = new List<Fuggohid>();
        List<string> orszaglist=new List<string>();
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Fuggohid ad in adatok)
            {
                if (!orszaglist.Contains(ad.orszag))
                {
                    orszaglist.Add(ad.orszag);
                }
            }
            kombo.ItemsSource = orszaglist;
        }
        
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string[] line = File.ReadAllLines("fuggohidak.csv");
            foreach (string er in line.Skip(1))
            {
                adatok.Add(new Fuggohid(er));
            }
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

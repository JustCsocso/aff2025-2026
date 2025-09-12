using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fuggohidak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        List<Fuggohid> adatok = new List<Fuggohid>();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
            string[] line = File.ReadAllLines("fuggohidak.csv");
            foreach(string er in line.Skip(1))
            {
                adatok.Add(new Fuggohid(er));
            }
           
            foreach(Fuggohid ad in adatok)
            {
                nevek.Items.Add(ad.nev);
            }
        }

        private void elott_Checked(object sender, RoutedEventArgs e)
        {
            int szam = 0;
            foreach(Fuggohid ad in adatok)
            {
                if (ad.ev < 2000)
                {
                    szam++;
                }
            }
            kiir.Text = szam.ToString();
            
        }

        private void utan_Checked(object sender, RoutedEventArgs e)
        {
            int szam1 = 0;
            foreach (Fuggohid ad in adatok)
            {
                if (ad.ev >= 2000)
                {
                    szam1++;
                }
            }
            kiir.Text = szam1.ToString();
        }

        private void nevek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(Fuggohid ad in adatok)
            {
             
                    if (nevek.SelectedItem==ad.nev)
                    {
                        helye.Text = ad.fhely.ToString();
                        orszagok.Text = ad.orszag.ToString();
                        hossza.Text = ad.hossz.ToString();
                        eve.Text = ad.ev.ToString();
                    }
           
            }
        }
       
        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           win2 win2=new win2();
           win2.Show();
           this.Hide();
            
        }
    }
}
using System.Collections.ObjectModel;
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

namespace elektronikus_ellenorzo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public enum TantargyTipus { kozismereti, szakmai }

    public class Tantargy
    {
        public string Nev { get; set; }
        public int Evfolyam { get; set; }
        public TantargyTipus Tipus { get; set; }
        public int HetiOraszam { get; set; }
        public int EvesOraszam

            {
                get
                {
                    int hetek = 36;
                    if (Evfolyam == 12 && Tipus == TantargyTipus.kozismereti) hetek = 31;
                    if (Evfolyam == 13) hetek = 31;
                    return hetek * HetiOraszam;
                }
            }
    }

    public class Tanulo
    {
        public string Nev;
        public List<Tantargy> Tantargyak = new();
    }

    public partial class MainWindow : Window
    {

        ObservableCollection<Tantargy> tantargyak = new(); ///Utánanézni

        public MainWindow()
        {
            InitializeComponent();

            tantargytipus.ItemsSource = Enum.GetValues(typeof(TantargyTipus));

            felvittTantargyak.ItemsSource = tantargyak;
            
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {
            var uj = new Tantargy
            {
                Nev = tantargyNev.Text,
                Evfolyam = int.Parse(((ComboBoxItem)evfolyam.SelectedItem).Content.ToString()),
                Tipus = (TantargyTipus)tantargytipus.SelectedItem,
                HetiOraszam = int.Parse(hetioraszam.Text)
            };

            tantargyak.Add(uj);
        }
    }
}
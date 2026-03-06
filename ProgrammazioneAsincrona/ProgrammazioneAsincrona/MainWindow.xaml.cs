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

namespace ProgrammazioneAsincrona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<char> lettere = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Random rnd = new Random();
        int lunParola = 1;
        int dimensione = 6;
        int numParole = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            LstBox.Items.Add("");
        }

        private void Btn_Estrai_Click(object sender, RoutedEventArgs e)
        {

            Lbl.Content = lettere[rnd.Next(1, lettere.Count())];
            lunParola++;
            LstBox.Items[numParole] = LstBox.Items[numParole].ToString() + Lbl.Content;

            if (lunParola == dimensione)
            {
                LstBox.Items.Add(Lbl.Content);
                lunParola = 0;
                numParole++;
            }
        }

        private void TxBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_LenParola_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxBox.Text, out int tmp) && tmp >= 1)
            {
                dimensione = tmp;
            }

            TxBox.Text = "";
        }
    }
}
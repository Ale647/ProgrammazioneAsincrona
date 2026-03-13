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
        int lunParola = 0;
        int dimensione = 6;
        int numParole = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            LstBox.Items.Add("");
            Ruota_Lettere();
        }

        private async void Btn_Estrai_Click(object sender, RoutedEventArgs e)
        {

            Lbl.Content = "Lettera estratta: " + lettere[rnd.Next(0, lettere.Count())];
            lunParola++;

            //Creo un stringa con il contenuto della label per prendere l'ultimo carattere e aggiungerlo alla parola in costruzione nella ListBox
            string testoLabel = Lbl.Content.ToString();
            char ultimoCarattere = testoLabel[testoLabel.Length - 1];

            LstBox.Items[numParole] = LstBox.Items[numParole].ToString() + ultimoCarattere;

            if (lunParola >= dimensione)
            {
                LstBox.Items.Add("");
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
<<<<<<< Updated upstream
                if(tmp <= dimensione && lunParola < dimensione)
                {
                    LstBox.Items.Add("");
                    numParole++;
                    lunParola = 0;
                }
=======

>>>>>>> Stashed changes

                dimensione = tmp;
            }


            
            TxBox.Text = "";


            
        }

        private async void Ruota_Lettere()
        {
            while (true)
            {

                Lbl_Ruota.Content = lettere[rnd.Next(0, lettere.Count())];
                await Task.Delay(100);
            }
        }

    }
}
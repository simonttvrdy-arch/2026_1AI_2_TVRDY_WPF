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

namespace _2026_1AI_2_TVRDY_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dpNarodeniny.SelectedDate = DateTime.Today;
        }

        private void btnPozdrav_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbMeno.Text))
            {
                // meno je prazdne
                MessageBox.Show("Zabudol si zadať meno!");
            }
            else
            {
                if (String.IsNullOrEmpty(tbPriezvisko.Text))
                {
                    // priezvisko je prazdne
                    MessageBox.Show("Zabudol si zadať priezvisko!");
                }
                else
                {
                    if (dpNarodeniny.SelectedDate == DateTime.Today)
                    {
                        // nebol zadany datum narodenia
                        MessageBox.Show("Zabudol si zadať dátum narodenia!");
                    }
                    else
                    {
                        string meno = tbMeno.Text;
                        string priezvisko = tbPriezvisko.Text;
                        int vek = DateTime.Now.Year - dpNarodeniny.SelectedDate.Value.Year;
                        MessageBox.Show("Ahoj " + meno + " " + priezvisko + " máš " + vek + " rokov.");
                    }

                }

            }

        }
    }
}
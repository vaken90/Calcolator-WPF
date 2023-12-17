using System.Globalization;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            // Istanzia il ViewModel e assegnalo come contesto dati
            PersonViewModel viewModel = new PersonViewModel();
            this.DataContext = viewModel;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            
            
            if (!double.TryParse(textBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double result))
            {
                // La conversione è riuscita, puoi usare il valore di result
                MessageBox.Show("Valore errato: " );
            }
            


            // Forza l'aggiornamento del source quando il testo cambia
            
            BindingExpression binding = textBox.GetBindingExpression(TextBox.TextProperty);
            binding?.UpdateSource();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;


            if (!double.TryParse(textBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double result))
            {
                // La conversione è riuscita, puoi usare il valore di result
                MessageBox.Show("Valore errato: ");
            }



            // Forza l'aggiornamento del source quando il testo cambia

            BindingExpression binding = textBox.GetBindingExpression(TextBox.TextProperty);
            binding?.UpdateSource();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
 

namespace WpfApp2
{
    class PersonViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> YourItemsSource { get; } = new ObservableCollection<string>
    {
        "+",
        "-",
        "/",
        "*"
    };

        private string _selectedItem;
        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        private string _num1;
        private string _num2;
        private string _num3;

        private ICommand _calcolaComando;

        public ICommand CalcolaComando
        {
            get
            {
                if (_calcolaComando == null)
                {
                    _calcolaComando = new RelayCommand(param => Calcola(param), canExecute => PuoEseguire());
                }
                return _calcolaComando;
            }
        }

        public void Calcola(object operation)
        {
            double n = Convert.ToDouble(_num1, new System.Globalization.CultureInfo("en-US"));
            double n2 = Convert.ToDouble(_num2, new System.Globalization.CultureInfo("en-US"));
            double n3 =0;

            switch (operation.ToString()){

                case "+":
                    n3 = n + n2;
                    break;
                case "-":
                    n3 = n - n2;
                    break;
                    case "*":
                    n3 = n * n2;
                    break;
                    case "/":
                    n3 = n / n2;
                    break;
                default:
                    _num3 = "invalid operation";
                    break;
            }
           
            Num3 = n3.ToString();
            
            
        }

        private bool PuoEseguire()
        {
            // Logica per determinare se l'addizione può essere eseguita
            return true; // o false a seconda delle tue condizioni
        }

        public string Num1
        {
            get { return _num1; }
            set
            {
                if (_num1 != value)
                {
                    _num1 = value;
                    OnPropertyChanged(nameof(Num1));
                }
            }
        }

        public string Num2
        {
            get { return _num2; }
            set
            {
                if (_num2 != value)
                {
                    _num2 = value;
                    OnPropertyChanged(nameof(Num2));
                }
            }
        }

        public string Num3
        {
            get { return _num3; }
            set
            {
                if (_num3 != value)
                {
                    _num3 = value;
                    OnPropertyChanged(nameof(Num3));
                }
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

protected virtual void OnPropertyChanged(string propertyName)
{
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
    }
}

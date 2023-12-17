using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
 

namespace WpfApp2
{
    class PersonViewModel : INotifyPropertyChanged
    {
        private string _num1;
        private string _num2;

        private ICommand _addizioneComando;

        public ICommand AddizioneComando
        {
            get
            {
                if (_addizioneComando == null)
                {
                    _addizioneComando = new RelayCommand(param => EseguiAddizione(), canExecute => PuoEseguire());
                }
                return _addizioneComando;
            }
        }

        public string EseguiAddizione()
        {
            double n = Convert.ToDouble(_num1, new System.Globalization.CultureInfo("en-US"));
            double n2 = Convert.ToDouble(_num2, new System.Globalization.CultureInfo("en-US"));
            double n3 = n + n2;
            // Logica per eseguire l'addizione
            MessageBox.Show(n3.ToString());
            
            return n3.ToString();
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



        public event PropertyChangedEventHandler? PropertyChanged;

protected virtual void OnPropertyChanged(string propertyName)
{
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
    }
}

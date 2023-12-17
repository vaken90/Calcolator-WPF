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
        private double _name;
        private double _name2;

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

        private void EseguiAddizione()
        {
            // Logica per eseguire l'addizione
            MessageBox.Show(Convert.ToString(_name + _name2));
        }

        private bool PuoEseguire()
        {
            // Logica per determinare se l'addizione può essere eseguita
            return true; // o false a seconda delle tue condizioni
        }

        public double Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public double Name2
        {
            get { return _name2; }
            set
            {
                if (_name2 != value)
                {
                    _name2 = value;
                    OnPropertyChanged(nameof(Name2));
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

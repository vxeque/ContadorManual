using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorManual.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Conteo
        {
            get { return _conteo; }
            set
            {
                if (value != _conteo)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public Contador()
        {
            Conteo = 0;

        }

        public void Contar()
        {
            Conteo += 1;
        }

        public void Reiniciar()
        {
            Conteo = 0; 
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

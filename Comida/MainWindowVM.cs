using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    //class MainWindowVM : INotifyPropertyChanged
    class MainWindowVM : ObservableObject
    {
        // ListBox de la izquierda: lista de platos.
        private ObservableCollection<Plato> _listaPlatos;
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return _listaPlatos; }
            set
            {
                //_listaPlatos = value;
                //NotifyPropertyChanged("ListaPlatos");
                SetProperty(ref _listaPlatos, value);
            }
        }

        // ListBox de la izquierda: plato seleccionado.
        private Plato _platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return _platoSeleccionado; }
            set
            {
                //_platoSeleccionado = value;
                //NotifyPropertyChanged("PlatoSeleccionado");
                SetProperty(ref _platoSeleccionado, value);
            }
        }

        // Formulario derecha: ComboBox, tipos de comida.
        private ObservableCollection<string> _tiposComida;
        public ObservableCollection<string> TiposComida
        {
            get { return _tiposComida; }
            set
            {
                //_tiposComida = value;
                //NotifyPropertyChanged("TiposComida");
                SetProperty(ref _tiposComida, value);
            }
        }

        public MainWindowVM()
        {
            // En el proyecto localizamos las fotos de los platos de comida en la carpeta "FotosPlatos".
            ListaPlatos = DatosServicio.GetSamples(@".\FotosPlatos");
            
            PlatoSeleccionado = null;

            TiposComida = DatosServicio.GetTipos();
        }

        public void QuitarSeleccionado()
        {
            PlatoSeleccionado = null;
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void NotifyPropertyChanged(string propertyName)
        //{
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}

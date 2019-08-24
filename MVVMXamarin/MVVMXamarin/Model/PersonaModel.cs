using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVVMXamarin.Model
{
    public class PersonaModel : INotifyPropertyChanged  
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged();
            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string apellido;

        public  string Apelllido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value;
                OnPropertyChanged();
            }
        }

        private string nombreCompleto;

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apelllido}";
            }
            set { nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));
            }
        }

        private Boolean isBusy = false;

        public Boolean IsBusy
        {
            get { return isBusy = false; }
            set { isBusy  = value;
                OnPropertyChanged();
            }
        }


        public string Mensaje
        {
            get { return $"Tu nombre completo es: {NombreCompleto}"; }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName] string nombre="")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nombre));
        }


    }
}

using MVVMXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePersonaPage : ContentPage
    {
        public DetallePersonaPage(PersonaModel modelo)
        {
            InitializeComponent();
            BindingContext = modelo;
        }
    }
}
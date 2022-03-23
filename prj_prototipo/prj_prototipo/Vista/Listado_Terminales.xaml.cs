using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_prototipo.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listado_Terminales : ContentPage
    {
        public Listado_Terminales()
        {
            InitializeComponent();
        }

        private async void BarraMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Registrar_Terminal ());
        }
    }
}
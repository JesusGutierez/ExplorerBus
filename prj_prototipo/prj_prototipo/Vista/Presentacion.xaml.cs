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
    public partial class Presentacion : ContentPage
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private async void btnAcceso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menu_opciones());
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prj_prototipo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void toLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Login());
        }
        private async void toRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Register());
        }

        private async void Barra_Clicked(object sender, EventArgs e)
        {
            //Llamar a Menu
            await Navigation.PushAsync(new Menu());
        }

        private async void btnIntra_Clicked(object sender, EventArgs e)
        {
            //Llamar a Intranet
            await Navigation.PushAsync(new Intranet());
        }

        private async void btnPresentación_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Presentacion());
        }

        private async void btnMantenimiento_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.Listado_Terminales());
        }

        private async void btnNosotros_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista.nosotros());
        }
    }
}

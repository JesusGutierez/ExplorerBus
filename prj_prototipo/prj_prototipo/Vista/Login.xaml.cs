using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using prj_prototipo.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_prototipo.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };
            Uri RequestUri = new Uri("https://senativi-8e553-default-rtdb.firebaseio.com/Usuarios/03.json");
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(user);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.GetAsync(RequestUri);
            


            if (response.StatusCode == HttpStatusCode.OK)
            {
                await Navigation.PushAsync(new nosotros());
                //txtEmail.Text = response.Content.ReadAsStringAsync().Result;
            } else
            {
                await DisplayAlert("Mensaje", "Datos Invalidos", "OK");
            }
        }
    }
}
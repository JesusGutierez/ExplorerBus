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
            UserData user = new UserData
            {
                email = txtEmail.Text,
                password = txtPassword.Text,
            };
            Uri RequestUri = new Uri("https://senativi-8e553-default-rtdb.firebaseio.com/usuarios.json");
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(user);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.GetAsync(RequestUri);

            var jsonParsed = JsonConvert.DeserializeObject<List<UserData>>(response.Content.ReadAsStringAsync().Result);
            bool has = jsonParsed.Any(cus => cus.email == txtEmail.Text && cus.password == txtPassword.Text);

            if (response.StatusCode == HttpStatusCode.OK && has)
            {
                await Navigation.PushAsync(new nosotros());
                //(string.Format("Nombre de usuario: {0}, Correo: {1}", jsonParsed[0].name, jsonParsed[0].email));
            } else
            {
                await DisplayAlert("Datos inválidos", "Porfavor verifique que haya ingresado correctamente el correo o la contraseña.", "OK");
            }
        }

        private void switchShowPswrd(object sender, EventArgs e)
        {
            if (cbxShowPassword.IsChecked)
            {
                txtPassword.IsPassword=false;
            } 
            else
            {
                txtPassword.IsPassword = true;
            }
        }
    }
}
using prj_prototipo.Modelo;
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
    public partial class menu_opciones : ContentPage
    {
        public List<ClsTerminales> lsterminales { get; set; }
        public menu_opciones()
        {
            InitializeComponent();
            lsterminales = new List<ClsTerminales>();
            lsterminales.Add(new ClsTerminales
            {
                foto = "mala.jpg",
                descrip = "Terminal Mala"
            });
            lsterminales.Add(new ClsTerminales
            {
                foto = "canete.jpg",
                descrip = "Terminal Cañete"
            });
            lsterminales.Add(new ClsTerminales
            {
                foto = "chincha.jpg",
                descrip = "Terminal Chincha"
            });
            lsterminales.Add(new ClsTerminales
            {
                foto = "ica.jpg",
                descrip = "Terminal Ica"
            });
            BindingContext = this;
        }

        private void btnChincha_Clicked(object sender, EventArgs e)
        {

        }
    }
}
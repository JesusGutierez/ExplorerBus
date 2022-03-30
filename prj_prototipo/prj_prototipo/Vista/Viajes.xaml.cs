using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_prototipo.Vista
{
    [DesignTimeVisible(false)]
    public partial class Viajes : ContentPage
    {
        public ObservableCollection<Card> ListDetails { get; set; }
        public Viajes()
        {
            InitializeComponent();
            ListDetails = new ObservableCollection<Card>
            {
                new Card{ImgIcon="huaral.jpg",
                    Name="Huaral",
                    Description="Destino: Huaral",
                    Description1="Tiempo de viaje : 3 horas",
                    Description2 = "Desde : S/.59"},
                new Card{ImgIcon="yauyos.jpg",
                    Name="Yauyos",
                    Description="Destino: Yauyos",
                    Description1="Tiempo de viaje : 4 horas",
                    Description2 = "Desde : S/.80"}
            };
            BindingContext = this;
        }
    }
    public class Card
    {
        public string ImgIcon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
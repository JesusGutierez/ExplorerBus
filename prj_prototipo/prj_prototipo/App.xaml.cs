using prj_prototipo.Modelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prj_prototipo
{
    // App hereda de la clase Application
    public partial class App : Application
    {
        //El Constructor se ejecuta automaticamente 
        public App()
        {
            InitializeComponent();
            crearBD();
            // NavigationPage es para navegar entre páginas
            MainPage = new NavigationPage(new MainPage());
        }
        //Métodos
        // public / private / protected

        public static DbContexto contexto { get; set; }
        private void crearBD()
        {
            var zona = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var ruta = System.IO.Path.Combine(zona, "Viajes");
            contexto = new DbContexto(ruta);

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

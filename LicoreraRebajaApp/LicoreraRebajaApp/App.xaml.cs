using LicoreraRebajaApp.Services;
using LicoreraRebajaApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LicoreraRebajaApp
{
    public partial class App : Application
    {
        //Atributos
        private static BaseDatos bd;


        //Constructor
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new ProductoDetalle());
            //MainPage = new NavigationPage(new AgregarProducto());
            MainPage = new NavigationPage(new ListaProductos());
        }

        //Métodos
        public static BaseDatos BD
        {
            get
            {
                if(bd == null)
                {
                    bd = new BaseDatos(Constantes.NombreBD);
                }
                return bd;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}

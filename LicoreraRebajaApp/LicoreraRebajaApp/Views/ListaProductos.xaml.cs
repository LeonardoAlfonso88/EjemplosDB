using LicoreraRebajaApp.Models;
using LicoreraRebajaApp.Services;
using LicoreraRebajaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LicoreraRebajaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaProductos : ContentPage
	{
        ProductoViewModel context = new ProductoViewModel();

		public ListaProductos ()
		{			
            BindingContext = context;
            InitializeComponent();
            LvProductos.ItemSelected += onProductSelected;
        }

        protected void onProductSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ProductoModel producto = (ProductoModel)e.SelectedItem;
                Navigation.PushAsync(new ProductoDetalle(producto));
            }
        }

        protected void OnCrearProductoClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AgregarProducto());
        }



    }
}
using LicoreraRebajaApp.Models;
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
	public partial class ProductoDetalle : ContentPage
	{
        ProductoViewModel context;

		public ProductoDetalle (ProductoModel producto)
		{
            context = new ProductoViewModel(producto);
            BindingContext = context;
            InitializeComponent ();
		}
	}
}
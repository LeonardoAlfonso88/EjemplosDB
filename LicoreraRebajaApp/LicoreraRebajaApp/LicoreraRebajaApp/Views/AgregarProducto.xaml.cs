using LicoreraRebajaApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LicoreraRebajaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarProducto : ContentPage
	{
        ProductoViewModel context = new ProductoViewModel();

        public AgregarProducto()
		{
            InitializeComponent ();
            BindingContext = new ProductoViewModel();
        }
	}
}
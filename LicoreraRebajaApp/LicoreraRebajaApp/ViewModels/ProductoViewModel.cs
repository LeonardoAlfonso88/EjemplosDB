using LicoreraRebajaApp.Models;
using LicoreraRebajaApp.Services;
using LicoreraRebajaApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LicoreraRebajaApp.ViewModels
{
    public class ProductoViewModel: ProductoModel
    {
        //Atributos
        ProductoModel producto;
        private ObservableCollection<ProductoModel> productos;
        public ProductoService service = new ProductoService();

        //Constructores
        public ProductoViewModel()
        {
            this.initialConfiguration();
            this.producto = new ProductoModel();
        }

        public ProductoViewModel(ProductoModel producto)
        {
            this.initialConfiguration();
            this.IdProducto = producto.IdProducto;
            this.Nombre = producto.Nombre;
            this.ValorUnitario = producto.ValorUnitario;
            this.Tamaño = producto.Tamaño;
        }

        //Eventos
        public Command GuardarCommand { get; set; }
        public Command BuscarCommand { get; set; }

        //Métodos
        #region Getters y Setters
        public ObservableCollection<ProductoModel> Productos
        {
            get { return productos; }
            set
            {
                productos = value;
                OnPropertyChanged("Productos");
            }
        }
        #endregion

        private async Task Guardar()
        {
            producto = new ProductoModel()
            {
                Nombre = Nombre,
                ValorUnitario = ValorUnitario,
                Tamaño = Tamaño
            };
            await service.Agregar(producto);
        }

        private async Task Buscar()
        {
            producto = await service.BuscarPorId(this.IdProducto);
            this.Nombre = producto.Nombre;
        }

        private async void initialConfiguration()
        {
            List<ProductoModel> productosList = await service.ObtenerTabla();
            productos = new ObservableCollection<ProductoModel>(productosList as List<ProductoModel>);
            GuardarCommand = new Command(async () => await Guardar(), () => true);
            BuscarCommand = new Command(async () => await Buscar(), () => true);
        }
    }
}

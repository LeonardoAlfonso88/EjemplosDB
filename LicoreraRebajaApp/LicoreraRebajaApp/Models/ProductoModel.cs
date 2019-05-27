using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LicoreraRebajaApp.Models
{
    public class ProductoModel : INotifyPropertyChanged
    {
        //Atributos

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        private int idProducto;
        private string nombre;
        private double valorUnitario;
        private int tamaño;

        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos
        #region Getters y Setters

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public double ValorUnitario
        {
            get { return valorUnitario; }
            set
            {
                valorUnitario = value;
                OnPropertyChanged();
            }
        }

        public int Tamaño
        {
            get { return tamaño; }
            set
            {
                tamaño = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}

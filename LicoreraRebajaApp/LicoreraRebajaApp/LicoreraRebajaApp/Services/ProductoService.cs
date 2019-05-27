using LicoreraRebajaApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LicoreraRebajaApp.Services
{
    public class ProductoService
    {
        //Atributos
        BaseDatos bd;

        //Constructor
        public ProductoService() : base()
        {
            bd = App.BD;
        }

        //Métodos

        public async Task<ProductoModel> Agregar(ProductoModel producto)
        {
            await bd.Set<ProductoModel>().AddAsync(producto);
            await bd.SaveChangesAsync();
            return producto;
        }

        public async Task<List<ProductoModel>> ObtenerTabla()
        {
            return await bd.Set<ProductoModel>().ToListAsync();
        }

        public virtual async Task<ProductoModel> BuscarPorId(int id)
        {
            return await bd.Set<ProductoModel>().FindAsync(id);
        }
    }
}

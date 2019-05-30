using LicoreraRebajaApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LicoreraRebajaApp.Services
{
    public class BaseDatos: DbContext
    {
        //Atributos
        private readonly string rutaBD;

        public DbSet<ProductoModel> Productos { get; set; }

        //Constructores
        public BaseDatos(string rutaDB)
        {
            this.rutaBD = rutaDB;
            Database.EnsureCreated();
        }
        //Métodos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IBaseDatos>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductoModel>().HasKey(p => p.IdProducto);
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());
        }

    }
}

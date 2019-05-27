using LicoreraRebajaApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LicoreraRebajaApp.Services
{
    public class ProductoConfiguration : IEntityTypeConfiguration<ProductoModel>
    {
        public void Configure(EntityTypeBuilder<ProductoModel> builder)
        {
            builder.HasKey(p => p.IdProducto);
        }
    }
}

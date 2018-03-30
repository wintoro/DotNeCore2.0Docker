using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogMicroservicesDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogMicroservicesDocker.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}
